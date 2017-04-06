namespace Alert_System
{
    partial class Alerts
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
            this.button1 = new System.Windows.Forms.Button();
            this.patientsns = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Read = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Parameter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientsns
            // 
            this.patientsns.Location = new System.Drawing.Point(12, 26);
            this.patientsns.Mask = "000000000";
            this.patientsns.Name = "patientsns";
            this.patientsns.Size = new System.Drawing.Size(144, 20);
            this.patientsns.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Patient SNS:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Date,
            this.Read,
            this.Parameter});
            this.listView1.Location = new System.Drawing.Point(12, 176);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(609, 193);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 24);
            this.button2.TabIndex = 35;
            this.button2.Text = "View Warnings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // Read
            // 
            this.Read.Text = "Read";
            // 
            // Parameter
            // 
            this.Parameter.Text = "Parameter";
            // 
            // Alerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 465);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.patientsns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Alerts";
            this.Text = "Alerts";
            this.Load += new System.EventHandler(this.Alerts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox patientsns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Read;
        private System.Windows.Forms.ColumnHeader Parameter;
    }
}