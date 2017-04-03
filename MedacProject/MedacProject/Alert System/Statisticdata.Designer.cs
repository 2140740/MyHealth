namespace Alert_System
{
    partial class Statisticdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statisticdata));
            this.validatestatic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pacientid = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxmin = new System.Windows.Forms.TextBox();
            this.boxmed = new System.Windows.Forms.TextBox();
            this.boxmax = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerbp2 = new System.Windows.Forms.DateTimePicker();
            this.choosedatespb = new System.Windows.Forms.RadioButton();
            this.dateTimePickerbp = new System.Windows.Forms.DateTimePicker();
            this.lastthreedaysbp = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerhr2 = new System.Windows.Forms.DateTimePicker();
            this.choosedateshr = new System.Windows.Forms.RadioButton();
            this.dateTimePickerhr = new System.Windows.Forms.DateTimePicker();
            this.lastthreedayshr = new System.Windows.Forms.RadioButton();
            this.btnshowhr = new System.Windows.Forms.Button();
            this.boxminhr = new System.Windows.Forms.TextBox();
            this.boxavehr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.boxmaxhr = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickeros2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickeros = new System.Windows.Forms.DateTimePicker();
            this.choosedatesos = new System.Windows.Forms.RadioButton();
            this.lastthreedaysos = new System.Windows.Forms.RadioButton();
            this.btnshowos = new System.Windows.Forms.Button();
            this.boxminos = new System.Windows.Forms.TextBox();
            this.boxaveos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.boxmaxos = new System.Windows.Forms.TextBox();
            this.alltimeos = new System.Windows.Forms.RadioButton();
            this.alltimehr = new System.Windows.Forms.RadioButton();
            this.alltimebp = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // validatestatic
            // 
            this.validatestatic.Location = new System.Drawing.Point(70, 51);
            this.validatestatic.Name = "validatestatic";
            this.validatestatic.Size = new System.Drawing.Size(89, 23);
            this.validatestatic.TabIndex = 11;
            this.validatestatic.Text = "Validate";
            this.validatestatic.UseVisualStyleBackColor = true;
            this.validatestatic.Click += new System.EventHandler(this.validatestatic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "SNS Patient";
            // 
            // pacientid
            // 
            this.pacientid.Location = new System.Drawing.Point(12, 25);
            this.pacientid.Mask = "000000000";
            this.pacientid.Name = "pacientid";
            this.pacientid.Size = new System.Drawing.Size(147, 20);
            this.pacientid.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Minimum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Average:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Maximum:";
            // 
            // boxmin
            // 
            this.boxmin.Location = new System.Drawing.Point(16, 40);
            this.boxmin.Name = "boxmin";
            this.boxmin.ReadOnly = true;
            this.boxmin.Size = new System.Drawing.Size(81, 20);
            this.boxmin.TabIndex = 17;
            // 
            // boxmed
            // 
            this.boxmed.Location = new System.Drawing.Point(111, 40);
            this.boxmed.Name = "boxmed";
            this.boxmed.ReadOnly = true;
            this.boxmed.Size = new System.Drawing.Size(81, 20);
            this.boxmed.TabIndex = 18;
            // 
            // boxmax
            // 
            this.boxmax.Location = new System.Drawing.Point(208, 40);
            this.boxmax.Name = "boxmax";
            this.boxmax.ReadOnly = true;
            this.boxmax.Size = new System.Drawing.Size(81, 20);
            this.boxmax.TabIndex = 19;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(16, 76);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(64, 20);
            this.btnshow.TabIndex = 20;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alltimebp);
            this.groupBox1.Controls.Add(this.dateTimePickerbp2);
            this.groupBox1.Controls.Add(this.choosedatespb);
            this.groupBox1.Controls.Add(this.dateTimePickerbp);
            this.groupBox1.Controls.Add(this.lastthreedaysbp);
            this.groupBox1.Controls.Add(this.boxmin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnshow);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boxmax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boxmed);
            this.groupBox1.Location = new System.Drawing.Point(270, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 175);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood Pressure:";
            // 
            // dateTimePickerbp2
            // 
            this.dateTimePickerbp2.Location = new System.Drawing.Point(129, 147);
            this.dateTimePickerbp2.Name = "dateTimePickerbp2";
            this.dateTimePickerbp2.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerbp2.TabIndex = 32;
            // 
            // choosedatespb
            // 
            this.choosedatespb.AutoSize = true;
            this.choosedatespb.Location = new System.Drawing.Point(16, 125);
            this.choosedatespb.Name = "choosedatespb";
            this.choosedatespb.Size = new System.Drawing.Size(95, 17);
            this.choosedatespb.TabIndex = 23;
            this.choosedatespb.TabStop = true;
            this.choosedatespb.Text = "Choose Dates:";
            this.choosedatespb.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerbp
            // 
            this.dateTimePickerbp.Location = new System.Drawing.Point(129, 121);
            this.dateTimePickerbp.Name = "dateTimePickerbp";
            this.dateTimePickerbp.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerbp.TabIndex = 31;
            // 
            // lastthreedaysbp
            // 
            this.lastthreedaysbp.AutoSize = true;
            this.lastthreedaysbp.Location = new System.Drawing.Point(16, 102);
            this.lastthreedaysbp.Name = "lastthreedaysbp";
            this.lastthreedaysbp.Size = new System.Drawing.Size(79, 17);
            this.lastthreedaysbp.TabIndex = 22;
            this.lastthreedaysbp.TabStop = true;
            this.lastthreedaysbp.Text = "Last 3 days";
            this.lastthreedaysbp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alltimehr);
            this.groupBox2.Controls.Add(this.dateTimePickerhr2);
            this.groupBox2.Controls.Add(this.choosedateshr);
            this.groupBox2.Controls.Add(this.dateTimePickerhr);
            this.groupBox2.Controls.Add(this.lastthreedayshr);
            this.groupBox2.Controls.Add(this.btnshowhr);
            this.groupBox2.Controls.Add(this.boxminhr);
            this.groupBox2.Controls.Add(this.boxavehr);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.boxmaxhr);
            this.groupBox2.Location = new System.Drawing.Point(270, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 181);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Heart Rate:";
            // 
            // dateTimePickerhr2
            // 
            this.dateTimePickerhr2.Location = new System.Drawing.Point(129, 157);
            this.dateTimePickerhr2.Name = "dateTimePickerhr2";
            this.dateTimePickerhr2.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerhr2.TabIndex = 32;
            // 
            // choosedateshr
            // 
            this.choosedateshr.AutoSize = true;
            this.choosedateshr.Location = new System.Drawing.Point(16, 135);
            this.choosedateshr.Name = "choosedateshr";
            this.choosedateshr.Size = new System.Drawing.Size(95, 17);
            this.choosedateshr.TabIndex = 28;
            this.choosedateshr.TabStop = true;
            this.choosedateshr.Text = "Choose Dates:";
            this.choosedateshr.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerhr
            // 
            this.dateTimePickerhr.Location = new System.Drawing.Point(129, 131);
            this.dateTimePickerhr.Name = "dateTimePickerhr";
            this.dateTimePickerhr.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerhr.TabIndex = 31;
            // 
            // lastthreedayshr
            // 
            this.lastthreedayshr.AutoSize = true;
            this.lastthreedayshr.Location = new System.Drawing.Point(16, 112);
            this.lastthreedayshr.Name = "lastthreedayshr";
            this.lastthreedayshr.Size = new System.Drawing.Size(79, 17);
            this.lastthreedayshr.TabIndex = 27;
            this.lastthreedayshr.TabStop = true;
            this.lastthreedayshr.Text = "Last 3 days";
            this.lastthreedayshr.UseVisualStyleBackColor = true;
            // 
            // btnshowhr
            // 
            this.btnshowhr.Location = new System.Drawing.Point(16, 80);
            this.btnshowhr.Name = "btnshowhr";
            this.btnshowhr.Size = new System.Drawing.Size(64, 20);
            this.btnshowhr.TabIndex = 21;
            this.btnshowhr.Text = "Show";
            this.btnshowhr.UseVisualStyleBackColor = true;
            this.btnshowhr.Click += new System.EventHandler(this.btnshowhr_Click);
            // 
            // boxminhr
            // 
            this.boxminhr.Location = new System.Drawing.Point(16, 44);
            this.boxminhr.Name = "boxminhr";
            this.boxminhr.ReadOnly = true;
            this.boxminhr.Size = new System.Drawing.Size(81, 20);
            this.boxminhr.TabIndex = 24;
            // 
            // boxavehr
            // 
            this.boxavehr.Location = new System.Drawing.Point(115, 44);
            this.boxavehr.Name = "boxavehr";
            this.boxavehr.ReadOnly = true;
            this.boxavehr.Size = new System.Drawing.Size(81, 20);
            this.boxavehr.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Minimum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Maximum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Average:";
            // 
            // boxmaxhr
            // 
            this.boxmaxhr.Location = new System.Drawing.Point(213, 44);
            this.boxmaxhr.Name = "boxmaxhr";
            this.boxmaxhr.ReadOnly = true;
            this.boxmaxhr.Size = new System.Drawing.Size(81, 20);
            this.boxmaxhr.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.alltimeos);
            this.groupBox3.Controls.Add(this.dateTimePickeros2);
            this.groupBox3.Controls.Add(this.dateTimePickeros);
            this.groupBox3.Controls.Add(this.choosedatesos);
            this.groupBox3.Controls.Add(this.lastthreedaysos);
            this.groupBox3.Controls.Add(this.btnshowos);
            this.groupBox3.Controls.Add(this.boxminos);
            this.groupBox3.Controls.Add(this.boxaveos);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.boxmaxos);
            this.groupBox3.Location = new System.Drawing.Point(270, 380);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 175);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oxygen Saturation:";
            // 
            // dateTimePickeros2
            // 
            this.dateTimePickeros2.Location = new System.Drawing.Point(129, 151);
            this.dateTimePickeros2.Name = "dateTimePickeros2";
            this.dateTimePickeros2.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickeros2.TabIndex = 30;
            // 
            // dateTimePickeros
            // 
            this.dateTimePickeros.Location = new System.Drawing.Point(129, 125);
            this.dateTimePickeros.Name = "dateTimePickeros";
            this.dateTimePickeros.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickeros.TabIndex = 28;
            // 
            // choosedatesos
            // 
            this.choosedatesos.AutoSize = true;
            this.choosedatesos.Location = new System.Drawing.Point(16, 129);
            this.choosedatesos.Name = "choosedatesos";
            this.choosedatesos.Size = new System.Drawing.Size(95, 17);
            this.choosedatesos.TabIndex = 28;
            this.choosedatesos.TabStop = true;
            this.choosedatesos.Text = "Choose Dates:";
            this.choosedatesos.UseVisualStyleBackColor = true;
            // 
            // lastthreedaysos
            // 
            this.lastthreedaysos.AutoSize = true;
            this.lastthreedaysos.Location = new System.Drawing.Point(16, 106);
            this.lastthreedaysos.Name = "lastthreedaysos";
            this.lastthreedaysos.Size = new System.Drawing.Size(79, 17);
            this.lastthreedaysos.TabIndex = 27;
            this.lastthreedaysos.TabStop = true;
            this.lastthreedaysos.Text = "Last 3 days";
            this.lastthreedaysos.UseVisualStyleBackColor = true;
            // 
            // btnshowos
            // 
            this.btnshowos.Location = new System.Drawing.Point(16, 80);
            this.btnshowos.Name = "btnshowos";
            this.btnshowos.Size = new System.Drawing.Size(64, 20);
            this.btnshowos.TabIndex = 21;
            this.btnshowos.Text = "Show";
            this.btnshowos.UseVisualStyleBackColor = true;
            this.btnshowos.Click += new System.EventHandler(this.btnshowos_Click);
            // 
            // boxminos
            // 
            this.boxminos.Location = new System.Drawing.Point(16, 44);
            this.boxminos.Name = "boxminos";
            this.boxminos.ReadOnly = true;
            this.boxminos.Size = new System.Drawing.Size(81, 20);
            this.boxminos.TabIndex = 24;
            // 
            // boxaveos
            // 
            this.boxaveos.Location = new System.Drawing.Point(115, 44);
            this.boxaveos.Name = "boxaveos";
            this.boxaveos.ReadOnly = true;
            this.boxaveos.Size = new System.Drawing.Size(81, 20);
            this.boxaveos.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Minimum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Maximum:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Average:";
            // 
            // boxmaxos
            // 
            this.boxmaxos.Location = new System.Drawing.Point(213, 44);
            this.boxmaxos.Name = "boxmaxos";
            this.boxmaxos.ReadOnly = true;
            this.boxmaxos.Size = new System.Drawing.Size(81, 20);
            this.boxmaxos.TabIndex = 26;
            // 
            // alltimeos
            // 
            this.alltimeos.AutoSize = true;
            this.alltimeos.Location = new System.Drawing.Point(111, 82);
            this.alltimeos.Name = "alltimeos";
            this.alltimeos.Size = new System.Drawing.Size(65, 17);
            this.alltimeos.TabIndex = 31;
            this.alltimeos.TabStop = true;
            this.alltimeos.Text = "All Time:";
            this.alltimeos.UseVisualStyleBackColor = true;
            // 
            // alltimehr
            // 
            this.alltimehr.AutoSize = true;
            this.alltimehr.Location = new System.Drawing.Point(111, 82);
            this.alltimehr.Name = "alltimehr";
            this.alltimehr.Size = new System.Drawing.Size(65, 17);
            this.alltimehr.TabIndex = 32;
            this.alltimehr.TabStop = true;
            this.alltimehr.Text = "All Time:";
            this.alltimehr.UseVisualStyleBackColor = true;
            // 
            // alltimebp
            // 
            this.alltimebp.AutoSize = true;
            this.alltimebp.Location = new System.Drawing.Point(111, 78);
            this.alltimebp.Name = "alltimebp";
            this.alltimebp.Size = new System.Drawing.Size(65, 17);
            this.alltimebp.TabIndex = 33;
            this.alltimebp.TabStop = true;
            this.alltimebp.Text = "All Time:";
            this.alltimebp.UseVisualStyleBackColor = true;
            // 
            // Statisticdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pacientid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.validatestatic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statisticdata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic Data";
            this.Load += new System.EventHandler(this.Statisticdata_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validatestatic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox pacientid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxmin;
        private System.Windows.Forms.TextBox boxmed;
        private System.Windows.Forms.TextBox boxmax;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnshowhr;
        private System.Windows.Forms.TextBox boxminhr;
        private System.Windows.Forms.TextBox boxavehr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxmaxhr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnshowos;
        private System.Windows.Forms.TextBox boxminos;
        private System.Windows.Forms.TextBox boxaveos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxmaxos;
        private System.Windows.Forms.RadioButton choosedatesos;
        private System.Windows.Forms.RadioButton lastthreedaysos;
        private System.Windows.Forms.RadioButton choosedatespb;
        private System.Windows.Forms.RadioButton lastthreedaysbp;
        private System.Windows.Forms.RadioButton choosedateshr;
        private System.Windows.Forms.RadioButton lastthreedayshr;
        private System.Windows.Forms.DateTimePicker dateTimePickeros;
        private System.Windows.Forms.DateTimePicker dateTimePickerbp2;
        private System.Windows.Forms.DateTimePicker dateTimePickerbp;
        private System.Windows.Forms.DateTimePicker dateTimePickerhr2;
        private System.Windows.Forms.DateTimePicker dateTimePickerhr;
        private System.Windows.Forms.DateTimePicker dateTimePickeros2;
        private System.Windows.Forms.RadioButton alltimeos;
        private System.Windows.Forms.RadioButton alltimehr;
        private System.Windows.Forms.RadioButton alltimebp;
    }
}