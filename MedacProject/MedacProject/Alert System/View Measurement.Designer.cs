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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Register Patient");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update Patient");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Patient", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("View Measurement");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Statistic data");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Measurement", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Measurement));
            this.button1 = new System.Windows.Forms.Button();
            this.pressuregraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.heartrategraph = new System.Windows.Forms.Button();
            this.oxygengraph = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statisticData = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pressuregraph
            // 
            this.pressuregraph.Location = new System.Drawing.Point(193, 34);
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
            this.panel1.Location = new System.Drawing.Point(193, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 341);
            this.panel1.TabIndex = 11;
            // 
            // heartrategraph
            // 
            this.heartrategraph.Location = new System.Drawing.Point(313, 34);
            this.heartrategraph.Name = "heartrategraph";
            this.heartrategraph.Size = new System.Drawing.Size(114, 23);
            this.heartrategraph.TabIndex = 12;
            this.heartrategraph.Text = "Heart Rate";
            this.heartrategraph.UseVisualStyleBackColor = true;
            this.heartrategraph.Click += new System.EventHandler(this.heartrategraph_Click);
            // 
            // oxygengraph
            // 
            this.oxygengraph.Location = new System.Drawing.Point(433, 34);
            this.oxygengraph.Name = "oxygengraph";
            this.oxygengraph.Size = new System.Drawing.Size(114, 23);
            this.oxygengraph.TabIndex = 13;
            this.oxygengraph.Text = "Oxygen Saturation";
            this.oxygengraph.UseVisualStyleBackColor = true;
            this.oxygengraph.Click += new System.EventHandler(this.oxygengraph_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statisticData
            // 
            this.statisticData.Name = "statisticData";
            this.statisticData.Size = new System.Drawing.Size(87, 20);
            this.statisticData.Text = "Statistic Data";
            this.statisticData.Click += new System.EventHandler(this.statisticData_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 174);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "RegisterPatient";
            treeNode1.Text = "Register Patient";
            treeNode2.Name = "UpdatePatient";
            treeNode2.Text = "Update Patient";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Patient";
            treeNode4.Name = "ViewMeasurement";
            treeNode4.Text = "View Measurement";
            treeNode5.Name = "Statistic data";
            treeNode5.Text = "Statistic data";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Measurement";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(154, 253);
            this.treeView1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Patient SNS:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 50);
            this.textBox8.Mask = "000000000";
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(144, 20);
            this.textBox8.TabIndex = 31;
            // 
            // View_Measurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 433);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.oxygengraph);
            this.Controls.Add(this.heartrategraph);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pressuregraph);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "View_Measurement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Measurement";
            this.Load += new System.EventHandler(this.View_Measurement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pressuregraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button heartrategraph;
        private System.Windows.Forms.Button oxygengraph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem statisticData;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBox8;
    }
}