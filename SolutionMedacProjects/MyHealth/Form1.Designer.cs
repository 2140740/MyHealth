namespace MyHealth
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textPacientId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textbp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textspo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texthr = new System.Windows.Forms.Label();
            this.checkBoxBP = new System.Windows.Forms.CheckBox();
            this.checkBoxSPO = new System.Windows.Forms.CheckBox();
            this.checkBoxHr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Patientid";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPacientId
            // 
            this.textPacientId.Location = new System.Drawing.Point(75, 31);
            this.textPacientId.Name = "textPacientId";
            this.textPacientId.Size = new System.Drawing.Size(100, 20);
            this.textPacientId.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Start monitoring values";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 206);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 108);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Blood Pressure:";
            // 
            // textbp
            // 
            this.textbp.AutoSize = true;
            this.textbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbp.Location = new System.Drawing.Point(250, 97);
            this.textbp.Name = "textbp";
            this.textbp.Size = new System.Drawing.Size(77, 25);
            this.textbp.TabIndex = 5;
            this.textbp.Text = "textbp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oxygen Saturation:";
            // 
            // textspo
            // 
            this.textspo.AutoSize = true;
            this.textspo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textspo.Location = new System.Drawing.Point(250, 138);
            this.textspo.Name = "textspo";
            this.textspo.Size = new System.Drawing.Size(89, 25);
            this.textspo.TabIndex = 7;
            this.textspo.Text = "textspo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Heart Rate:";
            // 
            // texthr
            // 
            this.texthr.AutoSize = true;
            this.texthr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texthr.Location = new System.Drawing.Point(250, 175);
            this.texthr.Name = "texthr";
            this.texthr.Size = new System.Drawing.Size(72, 25);
            this.texthr.TabIndex = 9;
            this.texthr.Text = "texthr";
            // 
            // checkBoxBP
            // 
            this.checkBoxBP.AutoSize = true;
            this.checkBoxBP.Location = new System.Drawing.Point(15, 105);
            this.checkBoxBP.Name = "checkBoxBP";
            this.checkBoxBP.Size = new System.Drawing.Size(69, 17);
            this.checkBoxBP.TabIndex = 10;
            this.checkBoxBP.Text = "Ver Valor";
            this.checkBoxBP.UseVisualStyleBackColor = true;
            // 
            // checkBoxSPO
            // 
            this.checkBoxSPO.AutoSize = true;
            this.checkBoxSPO.Location = new System.Drawing.Point(15, 146);
            this.checkBoxSPO.Name = "checkBoxSPO";
            this.checkBoxSPO.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSPO.TabIndex = 11;
            this.checkBoxSPO.Text = "Ver Valor";
            this.checkBoxSPO.UseVisualStyleBackColor = true;
            // 
            // checkBoxHr
            // 
            this.checkBoxHr.AutoSize = true;
            this.checkBoxHr.Location = new System.Drawing.Point(15, 183);
            this.checkBoxHr.Name = "checkBoxHr";
            this.checkBoxHr.Size = new System.Drawing.Size(69, 17);
            this.checkBoxHr.TabIndex = 12;
            this.checkBoxHr.Text = "Ver Valor";
            this.checkBoxHr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 324);
            this.Controls.Add(this.checkBoxHr);
            this.Controls.Add(this.checkBoxSPO);
            this.Controls.Add(this.checkBoxBP);
            this.Controls.Add(this.texthr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textspo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textPacientId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPacientId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textbp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textspo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label texthr;
        private System.Windows.Forms.CheckBox checkBoxBP;
        private System.Windows.Forms.CheckBox checkBoxSPO;
        private System.Windows.Forms.CheckBox checkBoxHr;
    }
}

