namespace Alert_System
{
    partial class AlertSytem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertSytem));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMeasurement = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMedicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.activePatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPatient,
            this.viewMeasurement,
            this.registerMedicToolStripMenuItem,
            this.activePatientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerPatient
            // 
            this.registerPatient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPatientToolStripMenuItem,
            this.updatePatientToolStripMenuItem});
            this.registerPatient.Name = "registerPatient";
            this.registerPatient.Size = new System.Drawing.Size(56, 20);
            this.registerPatient.Text = "Patient";
            // 
            // registerPatientToolStripMenuItem
            // 
            this.registerPatientToolStripMenuItem.Name = "registerPatientToolStripMenuItem";
            this.registerPatientToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.registerPatientToolStripMenuItem.Text = "Register Patient";
            this.registerPatientToolStripMenuItem.Click += new System.EventHandler(this.registerPatientToolStripMenuItem_Click);
            // 
            // updatePatientToolStripMenuItem
            // 
            this.updatePatientToolStripMenuItem.Name = "updatePatientToolStripMenuItem";
            this.updatePatientToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.updatePatientToolStripMenuItem.Text = "Update Patient";
            this.updatePatientToolStripMenuItem.Click += new System.EventHandler(this.updatePatientToolStripMenuItem_Click);
            // 
            // viewMeasurement
            // 
            this.viewMeasurement.Name = "viewMeasurement";
            this.viewMeasurement.Size = new System.Drawing.Size(120, 20);
            this.viewMeasurement.Text = "View Measurement";
            this.viewMeasurement.Click += new System.EventHandler(this.viewMeasurement_Click);
            // 
            // registerMedicToolStripMenuItem
            // 
            this.registerMedicToolStripMenuItem.Name = "registerMedicToolStripMenuItem";
            this.registerMedicToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.registerMedicToolStripMenuItem.Text = "Doctor";
            this.registerMedicToolStripMenuItem.Click += new System.EventHandler(this.registerMedicToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 27);
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
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // activePatientsToolStripMenuItem
            // 
            this.activePatientsToolStripMenuItem.Name = "activePatientsToolStripMenuItem";
            this.activePatientsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.activePatientsToolStripMenuItem.Text = "Active Patients";
            this.activePatientsToolStripMenuItem.Click += new System.EventHandler(this.activePatientsToolStripMenuItem_Click);
            // 
            // AlertSytem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 292);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AlertSytem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert Sytem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerPatient;
        private System.Windows.Forms.ToolStripMenuItem viewMeasurement;
        private System.Windows.Forms.ToolStripMenuItem registerPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePatientToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem registerMedicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activePatientsToolStripMenuItem;
    }
}

