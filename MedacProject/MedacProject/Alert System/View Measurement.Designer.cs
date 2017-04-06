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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Register Doctor");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Login Doctor");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Doctor", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Active Patients");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Measurement));
            this.button1 = new System.Windows.Forms.Button();
            this.pressuregraph = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.heartrategraph = new System.Windows.Forms.Button();
            this.oxygengraph = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statisticData = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.MaskedTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkshowvaluebp = new System.Windows.Forms.CheckBox();
            this.savegraph = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkshowvaluehr = new System.Windows.Forms.CheckBox();
            this.checkshowvaluesos = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            this.pressuregraph.Enabled = false;
            this.pressuregraph.Location = new System.Drawing.Point(683, 102);
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
            this.panel1.Location = new System.Drawing.Point(193, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 341);
            this.panel1.TabIndex = 11;
            // 
            // heartrategraph
            // 
            this.heartrategraph.Enabled = false;
            this.heartrategraph.Location = new System.Drawing.Point(683, 131);
            this.heartrategraph.Name = "heartrategraph";
            this.heartrategraph.Size = new System.Drawing.Size(114, 23);
            this.heartrategraph.TabIndex = 12;
            this.heartrategraph.Text = "Heart Rate";
            this.heartrategraph.UseVisualStyleBackColor = true;
            this.heartrategraph.Click += new System.EventHandler(this.heartrategraph_Click);
            // 
            // oxygengraph
            // 
            this.oxygengraph.Enabled = false;
            this.oxygengraph.Location = new System.Drawing.Point(683, 160);
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
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Line",
            "Point",
            "FastPoint",
            "Bubble",
            "Spline",
            "Column"});
            this.listBox1.Location = new System.Drawing.Point(193, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 32;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Chart type:";
            // 
            // checkshowvaluebp
            // 
            this.checkshowvaluebp.AutoSize = true;
            this.checkshowvaluebp.Enabled = false;
            this.checkshowvaluebp.Location = new System.Drawing.Point(193, 137);
            this.checkshowvaluebp.Name = "checkshowvaluebp";
            this.checkshowvaluebp.Size = new System.Drawing.Size(162, 17);
            this.checkshowvaluebp.TabIndex = 34;
            this.checkshowvaluebp.Text = "Show Values Blood Pressure";
            this.checkshowvaluebp.UseVisualStyleBackColor = true;
            this.checkshowvaluebp.CheckedChanged += new System.EventHandler(this.checkshowvaluebp_CheckedChanged);
            // 
            // savegraph
            // 
            this.savegraph.Location = new System.Drawing.Point(459, 172);
            this.savegraph.Name = "savegraph";
            this.savegraph.Size = new System.Drawing.Size(81, 33);
            this.savegraph.TabIndex = 36;
            this.savegraph.Text = "Save Graph";
            this.savegraph.UseVisualStyleBackColor = true;
            this.savegraph.Click += new System.EventHandler(this.savegraph_Click);
            // 
            // checkshowvaluehr
            // 
            this.checkshowvaluehr.AutoSize = true;
            this.checkshowvaluehr.Enabled = false;
            this.checkshowvaluehr.Location = new System.Drawing.Point(193, 160);
            this.checkshowvaluehr.Name = "checkshowvaluehr";
            this.checkshowvaluehr.Size = new System.Drawing.Size(143, 17);
            this.checkshowvaluehr.TabIndex = 37;
            this.checkshowvaluehr.Text = "Show Values Heart Rate";
            this.checkshowvaluehr.UseVisualStyleBackColor = true;
            this.checkshowvaluehr.CheckedChanged += new System.EventHandler(this.checkshowvaluehr_CheckedChanged);
            // 
            // checkshowvaluesos
            // 
            this.checkshowvaluesos.AutoSize = true;
            this.checkshowvaluesos.Enabled = false;
            this.checkshowvaluesos.Location = new System.Drawing.Point(193, 183);
            this.checkshowvaluesos.Name = "checkshowvaluesos";
            this.checkshowvaluesos.Size = new System.Drawing.Size(178, 17);
            this.checkshowvaluesos.TabIndex = 38;
            this.checkshowvaluesos.Text = "Show Values Oxygen Saturation";
            this.checkshowvaluesos.UseVisualStyleBackColor = true;
            this.checkshowvaluesos.CheckedChanged += new System.EventHandler(this.checkshowvaluesos_CheckedChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 299);
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
            treeNode7.Name = "Register Doctor";
            treeNode7.Text = "Register Doctor";
            treeNode8.Name = "Login Doctor";
            treeNode8.Text = "Login Doctor";
            treeNode9.Name = "Doctor";
            treeNode9.Text = "Doctor";
            treeNode10.Name = "Active Patients";
            treeNode10.Text = "Active Patients";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(154, 253);
            this.treeView1.TabIndex = 39;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // View_Measurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 564);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.checkshowvaluesos);
            this.Controls.Add(this.checkshowvaluehr);
            this.Controls.Add(this.savegraph);
            this.Controls.Add(this.checkshowvaluebp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBox8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkshowvaluebp;
        private System.Windows.Forms.Button savegraph;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkshowvaluehr;
        private System.Windows.Forms.CheckBox checkshowvaluesos;
        private System.Windows.Forms.TreeView treeView1;
    }
}