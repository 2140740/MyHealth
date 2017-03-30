namespace MedacProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textspo = new System.Windows.Forms.Label();
            this.textbp = new System.Windows.Forms.Label();
            this.texthr = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textPacientId = new System.Windows.Forms.TextBox();
            this.textBoxMedation = new System.Windows.Forms.TextBox();
            this.monitoring = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.checkBoxBP = new System.Windows.Forms.CheckBox();
            this.checkBoxSPO = new System.Windows.Forms.CheckBox();
            this.checkBoxHr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blood Pressure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oxygen Saturation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Heart Rate:";
            // 
            // textspo
            // 
            this.textspo.AutoSize = true;
            this.textspo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textspo.Location = new System.Drawing.Point(252, 181);
            this.textspo.Name = "textspo";
            this.textspo.Size = new System.Drawing.Size(68, 20);
            this.textspo.TabIndex = 4;
            this.textspo.Text = "textspo";
            // 
            // textbp
            // 
            this.textbp.AutoSize = true;
            this.textbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbp.Location = new System.Drawing.Point(252, 139);
            this.textbp.Name = "textbp";
            this.textbp.Size = new System.Drawing.Size(59, 20);
            this.textbp.TabIndex = 5;
            this.textbp.Text = "textbp";
            // 
            // texthr
            // 
            this.texthr.AutoSize = true;
            this.texthr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texthr.Location = new System.Drawing.Point(252, 222);
            this.texthr.Name = "texthr";
            this.texthr.Size = new System.Drawing.Size(55, 20);
            this.texthr.TabIndex = 6;
            this.texthr.Text = "texthr";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "mmHg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "bpm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mediation Rate:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "second(s)";
            // 
            // textPacientId
            // 
            this.textPacientId.Location = new System.Drawing.Point(75, 6);
            this.textPacientId.Name = "textPacientId";
            this.textPacientId.Size = new System.Drawing.Size(138, 20);
            this.textPacientId.TabIndex = 12;
            // 
            // textBoxMedation
            // 
            this.textBoxMedation.Location = new System.Drawing.Point(226, 71);
            this.textBoxMedation.Name = "textBoxMedation";
            this.textBoxMedation.Size = new System.Drawing.Size(138, 20);
            this.textBoxMedation.TabIndex = 13;
            // 
            // monitoring
            // 
            this.monitoring.Location = new System.Drawing.Point(15, 92);
            this.monitoring.Name = "monitoring";
            this.monitoring.Size = new System.Drawing.Size(158, 23);
            this.monitoring.TabIndex = 14;
            this.monitoring.Text = "Start monitoring values";
            this.monitoring.UseVisualStyleBackColor = true;
            this.monitoring.Click += new System.EventHandler(this.monitoring_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(226, 4);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(98, 23);
            this.validate.TabIndex = 15;
            this.validate.Text = "Validate";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // checkBoxBP
            // 
            this.checkBoxBP.AutoSize = true;
            this.checkBoxBP.Location = new System.Drawing.Point(12, 143);
            this.checkBoxBP.Name = "checkBoxBP";
            this.checkBoxBP.Size = new System.Drawing.Size(83, 17);
            this.checkBoxBP.TabIndex = 16;
            this.checkBoxBP.Text = "Show Value";
            this.checkBoxBP.UseVisualStyleBackColor = true;
            // 
            // checkBoxSPO
            // 
            this.checkBoxSPO.AutoSize = true;
            this.checkBoxSPO.Location = new System.Drawing.Point(12, 185);
            this.checkBoxSPO.Name = "checkBoxSPO";
            this.checkBoxSPO.Size = new System.Drawing.Size(83, 17);
            this.checkBoxSPO.TabIndex = 17;
            this.checkBoxSPO.Text = "Show Value";
            this.checkBoxSPO.UseVisualStyleBackColor = true;
            // 
            // checkBoxHr
            // 
            this.checkBoxHr.AutoSize = true;
            this.checkBoxHr.Location = new System.Drawing.Point(12, 226);
            this.checkBoxHr.Name = "checkBoxHr";
            this.checkBoxHr.Size = new System.Drawing.Size(83, 17);
            this.checkBoxHr.TabIndex = 18;
            this.checkBoxHr.Text = "Show Value";
            this.checkBoxHr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 290);
            this.Controls.Add(this.checkBoxHr);
            this.Controls.Add(this.checkBoxSPO);
            this.Controls.Add(this.checkBoxBP);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.monitoring);
            this.Controls.Add(this.textBoxMedation);
            this.Controls.Add(this.textPacientId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.texthr);
            this.Controls.Add(this.textbp);
            this.Controls.Add(this.textspo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label textspo;
        private System.Windows.Forms.Label textbp;
        private System.Windows.Forms.Label texthr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textPacientId;
        private System.Windows.Forms.TextBox textBoxMedation;
        private System.Windows.Forms.Button monitoring;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.CheckBox checkBoxBP;
        private System.Windows.Forms.CheckBox checkBoxSPO;
        private System.Windows.Forms.CheckBox checkBoxHr;
    }
}

