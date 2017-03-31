namespace MedacProject
{
    partial class MedicalID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalID));
            this.label1 = new System.Windows.Forms.Label();
            this.PatientSNS = new System.Windows.Forms.MaskedTextBox();
            this.data = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient SNS:";
            // 
            // PatientSNS
            // 
            this.PatientSNS.Location = new System.Drawing.Point(342, 139);
            this.PatientSNS.Mask = "000000000";
            this.PatientSNS.Name = "PatientSNS";
            this.PatientSNS.Size = new System.Drawing.Size(100, 20);
            this.PatientSNS.TabIndex = 1;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(367, 165);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(75, 23);
            this.data.TabIndex = 2;
            this.data.Text = "View Data";
            this.data.UseVisualStyleBackColor = true;
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.surname,
            this.birthdate,
            this.sns});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 110);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 120;
            // 
            // surname
            // 
            this.surname.Text = "Surname";
            this.surname.Width = 120;
            // 
            // birthdate
            // 
            this.birthdate.Text = "Birthdate";
            this.birthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.birthdate.Width = 80;
            // 
            // sns
            // 
            this.sns.Text = "SNS";
            this.sns.Width = 100;
            // 
            // MedicalID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 200);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.PatientSNS);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicalID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalID";
            this.Load += new System.EventHandler(this.MedicalID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PatientSNS;
        private System.Windows.Forms.Button data;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader surname;
        private System.Windows.Forms.ColumnHeader birthdate;
        private System.Windows.Forms.ColumnHeader sns;
    }
}