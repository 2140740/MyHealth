namespace Alert_System
{
    partial class View_Measurement
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pressuregraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.heartrategraph = new System.Windows.Forms.Button();
            this.oxygengraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(40, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(144, 20);
            this.textBox8.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pressuregraph
            // 
            this.pressuregraph.Location = new System.Drawing.Point(40, 60);
            this.pressuregraph.Name = "pressuregraph";
            this.pressuregraph.Size = new System.Drawing.Size(114, 23);
            this.pressuregraph.TabIndex = 10;
            this.pressuregraph.Text = "Blood Pressure";
            this.pressuregraph.UseVisualStyleBackColor = true;
            this.pressuregraph.Click += new System.EventHandler(this.pressuregraph_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Enabled = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(604, 341);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(200, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 341);
            this.panel1.TabIndex = 11;
            // 
            // heartrategraph
            // 
            this.heartrategraph.Location = new System.Drawing.Point(40, 89);
            this.heartrategraph.Name = "heartrategraph";
            this.heartrategraph.Size = new System.Drawing.Size(114, 23);
            this.heartrategraph.TabIndex = 12;
            this.heartrategraph.Text = "Heart Rate";
            this.heartrategraph.UseVisualStyleBackColor = true;
            this.heartrategraph.Click += new System.EventHandler(this.heartrategraph_Click);
            // 
            // oxygengraph
            // 
            this.oxygengraph.Location = new System.Drawing.Point(40, 118);
            this.oxygengraph.Name = "oxygengraph";
            this.oxygengraph.Size = new System.Drawing.Size(114, 23);
            this.oxygengraph.TabIndex = 13;
            this.oxygengraph.Text = "Oxygen Saturation";
            this.oxygengraph.UseVisualStyleBackColor = true;
            this.oxygengraph.Click += new System.EventHandler(this.oxygengraph_Click);
            // 
            // View_Measurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 490);
            this.Controls.Add(this.oxygengraph);
            this.Controls.Add(this.heartrategraph);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.pressuregraph);
            this.Controls.Add(this.button1);
            this.Name = "View_Measurement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Measurement";
            this.Load += new System.EventHandler(this.View_Measurement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pressuregraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button heartrategraph;
        private System.Windows.Forms.Button oxygengraph;
    }
}