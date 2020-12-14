
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl1 = new System.Windows.Forms.Label();
            this.magicButton = new System.Windows.Forms.Button();
            this.lblRekord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sudokuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(792, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Eredmények";
            this.chart1.Series.Add(series2);
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
            // lblRekord
            // 
            this.lblRekord.AutoSize = true;
            this.lblRekord.Location = new System.Drawing.Point(638, 375);
            this.lblRekord.Name = "lblRekord";
            this.lblRekord.Size = new System.Drawing.Size(65, 20);
            this.lblRekord.TabIndex = 5;
            this.lblRekord.Text = "Rekord:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 692);
            this.Controls.Add(this.sudokuButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRekord);
            this.Controls.Add(this.magicButton);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Label lblRekord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sudokuButton;
    }
}

