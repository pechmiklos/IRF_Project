
namespace magicsq
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl1 = new System.Windows.Forms.Label();
            this.magicButton = new System.Windows.Forms.Button();
            this.labelRekord = new System.Windows.Forms.Label();
            this.lblRekord = new System.Windows.Forms.Label();
            this.sudokuButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gametypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(30, 22);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(560, 497);
            this.mainPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTime.Location = new System.Drawing.Point(689, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(87, 26);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Semmi";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(899, 103);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Eredmények";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(370, 292);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(609, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 20);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Eltelt idő:";
            // 
            // magicButton
            // 
            this.magicButton.Location = new System.Drawing.Point(52, 550);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(144, 45);
            this.magicButton.TabIndex = 4;
            this.magicButton.Text = "Bűvös négyzet";
            this.magicButton.UseVisualStyleBackColor = true;
            this.magicButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRekord
            // 
            this.labelRekord.AutoSize = true;
            this.labelRekord.Location = new System.Drawing.Point(805, 422);
            this.labelRekord.Name = "labelRekord";
            this.labelRekord.Size = new System.Drawing.Size(65, 20);
            this.labelRekord.TabIndex = 5;
            this.labelRekord.Text = "Rekord:";
            // 
            // lblRekord
            // 
            this.lblRekord.AutoSize = true;
            this.lblRekord.Location = new System.Drawing.Point(906, 422);
            this.lblRekord.Name = "lblRekord";
            this.lblRekord.Size = new System.Drawing.Size(0, 20);
            this.lblRekord.TabIndex = 6;
            // 
            // sudokuButton
            // 
            this.sudokuButton.Location = new System.Drawing.Point(273, 550);
            this.sudokuButton.Name = "sudokuButton";
            this.sudokuButton.Size = new System.Drawing.Size(145, 45);
            this.sudokuButton.TabIndex = 7;
            this.sudokuButton.Text = "Sudoku";
            this.sudokuButton.UseVisualStyleBackColor = true;
            this.sudokuButton.Click += new System.EventHandler(this.sudokuButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gametypeDataGridViewTextBoxColumn,
            this.gameNumberDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resultBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(584, 585);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(514, 176);
            this.dataGridView1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sudoku",
            "Bűvöskocka"});
            this.comboBox1.Location = new System.Drawing.Point(765, 490);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gametypeDataGridViewTextBoxColumn
            // 
            this.gametypeDataGridViewTextBoxColumn.DataPropertyName = "Gametype";
            this.gametypeDataGridViewTextBoxColumn.HeaderText = "Játéktípus";
            this.gametypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gametypeDataGridViewTextBoxColumn.Name = "gametypeDataGridViewTextBoxColumn";
            this.gametypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // gameNumberDataGridViewTextBoxColumn
            // 
            this.gameNumberDataGridViewTextBoxColumn.DataPropertyName = "GameNumber";
            this.gameNumberDataGridViewTextBoxColumn.HeaderText = "Sorszám";
            this.gameNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.gameNumberDataGridViewTextBoxColumn.Name = "gameNumberDataGridViewTextBoxColumn";
            this.gameNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Idő";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 150;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataSource = typeof(magicsq.Result);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 795);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sudokuButton);
            this.Controls.Add(this.lblRekord);
            this.Controls.Add(this.labelRekord);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button magicButton;
        private System.Windows.Forms.Label labelRekord;
        private System.Windows.Forms.Label lblRekord;
        private System.Windows.Forms.Button sudokuButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gametypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

