using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace magicsq
{
    public partial class Form1 : Form
    {
        BindingList<Result> results = new BindingList<Result>();
        BindingList<Result> selectedresults = new BindingList<Result>();
        private Random _rng = new Random();
        private Magicsquare _currentQuiz = null;
        public int magicnumber = 0;
        public int sudokunumber = 0;
        private List<Magicsquare> _magicssquares = new List<Magicsquare>();
        private List<Result> chartresults = new List<Result>();
        
        public Form1()
        {
            InitializeComponent();
            chart1.DataSource = chartresults;
            dataGridView1.DataSource = results;
            
            
            
           
        }

        private void CreatePlayField(int lenght,int size)
        {
            int lineWidth = 5;
            for (int row = 0; row < lenght; row++)
            {
                for (int col = 0; col < lenght; col++)
                {
                    Magicfield mf = new Magicfield();
                    mf.Height = size;
                    mf.Width = size;
                    mf.Left = col * mf.Width + (int)(Math.Floor((double)(col/3))) * lineWidth;
                    mf.Top = row * mf.Height + (int)(Math.Floor((double)(row / 3))) * lineWidth;
                    mf.MouseDown += Mf_MouseDown;
                    mainPanel.Controls.Add(mf);

                }
            }
           

        }

        private void Mf_MouseDown(object sender, MouseEventArgs e)
        {

            string val = "";
            foreach (var mf in mainPanel.Controls.OfType<Magicfield>())
            {
                val += mf.Value.ToString();
            }

                if (val.Equals(_currentQuiz.Solution))
                {
                    EndGame();
                }
            
        }

        private void EndGame()
        {
            int gamenumber;
            string gametype;
            int counter = 0;
            foreach (var mf in mainPanel.Controls.OfType<Magicfield>())
            {
                mf.Active = false;
                counter += 1;

            }
            timer1.Stop();
            if (counter==9)
            {
                gametype = "Bűvösnégyzet";
                magicnumber += 1;
                gamenumber = magicnumber ;

            }
            else
            {
                gametype = "Sudoku";
                sudokunumber += 1;
                gamenumber = sudokunumber ;
            }
            
            MessageBox.Show("Kész,  " + time + " másodperc alatt");
            var r = new Result();
            r.Id = Guid.NewGuid();
            r.Gametype = gametype;
            r.GameNumber = gamenumber;
            r.Time = time;
            results.Add(r);
            SetGraph();                       
            GetRecord();
            _currentQuiz = GetRandomQuiz();
        }

        private void GetRecord()
        {

            int max = 0;
            foreach (var m in chartresults)
            {
                if (m.Time > max)
                {
                    max = m.Time;
                }
            }
            int min = max;
            foreach (var mn in chartresults)
            {
                if (mn.Time < min)
                {
                    min = mn.Time;
                }
            }
            int counter = 0;
            foreach (var rs in chartresults)
            {
                counter += 1;
            }
            if (counter>0)
            {
                lblRekord.Text = min.ToString() + " mp";
            }
            else
            {
                lblRekord.Text = "";
            }
          
        }

        private void LoadMagicsquares(string file)
        {
            _magicssquares.Clear();
           
            using (StreamReader sr = new StreamReader(file,Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('.');
                     Magicsquare m = new Magicsquare();
                     m.Quiz = line[0];
                     m.Solution = line[1];
                    _magicssquares.Add(m);
                   
                    
                }
                
            }
           
        }
        private Magicsquare GetRandomQuiz()
        {
            int randomNumber = _rng.Next(_magicssquares.Count);
            return _magicssquares[randomNumber];
        }
        private void NewGame()
        {
            time = 0;
          
            timer1.Start();

            int counter = 0;
              foreach (var mf in mainPanel.Controls.OfType<Magicfield>())
            {
                mf.Value = int.Parse(_currentQuiz.Quiz[counter].ToString());
                mf.Active = mf.Value == 0;
                counter++;
            }

        }
        public int time;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time + 1;
            lblTime.Text = time.ToString() + " mp";
        }

       

        private void ClearPanel()
        {
            mainPanel.Controls.Clear();
        }

        private void magicButton_Click_1(object sender, EventArgs e)
        {
            LoadMagicsquares("magicsquare.csv");
            ClearPanel();
            CreatePlayField(3, 60);
            _currentQuiz = GetRandomQuiz();
            NewGame();
            comboBox1.SelectedItem = "Bűvösnégyzet";


        }

        private void sudokuButton_Click(object sender, EventArgs e)
        {
            LoadMagicsquares("sudoku.csv");
            ClearPanel();
            CreatePlayField(9,30);
            _currentQuiz = GetRandomQuiz();
            NewGame();
            comboBox1.SelectedItem = "Sudoku";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = selectedresults;
            SetGraph();
            GetRecord();
        }

        private void SetGraph()
        {
            SelectResults();
            chart1.DataSource = chartresults;
            var series = chart1.Series[0];
            int counter=0;
            
            foreach (var rs in chartresults)
            {
                counter += 1;
            }

            if (counter==1)
            {
                series.ChartType = SeriesChartType.Point;
            }
            else
            {
                series.ChartType = SeriesChartType.Line;
            } 


            series.XValueMember = "GameNumber";
            series.YValueMembers = "Time";
            series.BorderWidth = 2;
        }

        private void SelectResults()
        {
            chartresults.Clear();
            selectedresults.Clear();
            var gt = (string)comboBox1.SelectedItem;
            foreach (var r in results)
            {
                if (r.Gametype == gt)
                {
                    var rs = new Result();
                    rs.Id = r.Id;
                    rs.Gametype = gt;
                    rs.GameNumber = r.GameNumber;
                    rs.Time = r.Time;
                    chartresults.Add(r);
                    selectedresults.Add(r);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndGame();
        }
    }
}
