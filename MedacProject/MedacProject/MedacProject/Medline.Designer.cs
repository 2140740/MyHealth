namespace MedacProject
{
    partial class Medline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medline));
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxsearch = new System.Windows.Forms.TextBox();
            this.buttonGO = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.boxurl = new System.Windows.Forms.TextBox();
            this.summarybrowser = new System.Windows.Forms.WebBrowser();
            this.browsertitle = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 77);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search:";
            // 
            // boxsearch
            // 
            this.boxsearch.Location = new System.Drawing.Point(59, 23);
            this.boxsearch.Name = "boxsearch";
            this.boxsearch.Size = new System.Drawing.Size(100, 20);
            this.boxsearch.TabIndex = 4;
            // 
            // buttonGO
            // 
            this.buttonGO.Location = new System.Drawing.Point(165, 21);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(75, 23);
            this.buttonGO.TabIndex = 6;
            this.buttonGO.Text = "Go";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(276, 375);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(407, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 95);
            this.listBox1.TabIndex = 13;
            // 
            // boxurl
            // 
            this.boxurl.Location = new System.Drawing.Point(407, 260);
            this.boxurl.Name = "boxurl";
            this.boxurl.Size = new System.Drawing.Size(355, 20);
            this.boxurl.TabIndex = 15;
            // 
            // summarybrowser
            // 
            this.summarybrowser.Location = new System.Drawing.Point(406, 295);
            this.summarybrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.summarybrowser.Name = "summarybrowser";
            this.summarybrowser.Size = new System.Drawing.Size(356, 186);
            this.summarybrowser.TabIndex = 16;
            // 
            // browsertitle
            // 
            this.browsertitle.Location = new System.Drawing.Point(406, 77);
            this.browsertitle.MinimumSize = new System.Drawing.Size(20, 20);
            this.browsertitle.Name = "browsertitle";
            this.browsertitle.Size = new System.Drawing.Size(356, 58);
            this.browsertitle.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Full Summary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "URL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alternative Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title:";
            // 
            // Medline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 511);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.boxurl);
            this.Controls.Add(this.summarybrowser);
            this.Controls.Add(this.browsertitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxsearch);
            this.Controls.Add(this.buttonGO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Medline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxsearch;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox boxurl;
        private System.Windows.Forms.WebBrowser summarybrowser;
        private System.Windows.Forms.WebBrowser browsertitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}