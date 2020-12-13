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
        private Random _rng = new Random();
        private Magicsquare _currentQuiz = null;
        public int gamenumber = 0;
       
        private List<Magicsquare> _magicssquares = new List<Magicsquare>();
        private List<Result> _results = new List<Result>();
        
        public Form1()
        {
            InitializeComponent();
            chart1.DataSource = _results;
           
            CreatePlayField();
            LoadMagicsquares();
           
        }

        private void CreatePlayField()
        {
            int lineWidth = 5;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Magicfield mf = new Magicfield();
                    mf.Left = col * mf.Width + lineWidth;
                    mf.Top = row * mf.Height + lineWidth;
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
            foreach (var mf in mainPanel.Controls.OfType<Magicfield>())
            {
                mf.Active = false;
            }
            timer1.Stop();
            MessageBox.Show("Kész,  " + time + " másodperc alatt");
            var r = new Result();
            r.GameNumber = gamenumber;
            r.Time = time;
            _results.Add(r);
            chart1.DataSource = _results;
            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "GameNumber";
            series.YValueMembers = "Time";
            series.BorderWidth = 2;





            _currentQuiz = GetRandomQuiz();
           
        }

        private void LoadMagicsquares()
        {
            _magicssquares.Clear();
           
            using (StreamReader sr = new StreamReader("magicsquare.csv",Encoding.Default))
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
            gamenumber = gamenumber + 1;
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
            label1.Text = time.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            _currentQuiz = GetRandomQuiz();
            NewGame();
        }
    }
}
