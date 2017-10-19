namespace GUI
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
            this.btnaddrss = new System.Windows.Forms.Button();
            this.tbpodurl = new System.Windows.Forms.TextBox();
            this.lbpodeps = new System.Windows.Forms.ListBox();
            this.tbpodname = new System.Windows.Forms.TextBox();
            this.tbpoddesc = new System.Windows.Forms.RichTextBox();
            this.tbepdesc = new System.Windows.Forms.RichTextBox();
            this.lblpoddesc = new System.Windows.Forms.Label();
            this.lblepdesc = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblurl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnaddrss
            // 
            this.btnaddrss.Location = new System.Drawing.Point(13, 208);
            this.btnaddrss.Name = "btnaddrss";
            this.btnaddrss.Size = new System.Drawing.Size(83, 23);
            this.btnaddrss.TabIndex = 0;
            this.btnaddrss.Text = "Add Pod";
            this.btnaddrss.UseVisualStyleBackColor = true;
            this.btnaddrss.Click += new System.EventHandler(this.btnaddrss_Click);
            // 
            // tbpodurl
            // 
            this.tbpodurl.Location = new System.Drawing.Point(12, 75);
            this.tbpodurl.Name = "tbpodurl";
            this.tbpodurl.Size = new System.Drawing.Size(283, 22);
            this.tbpodurl.TabIndex = 1;
            // 
            // lbpodeps
            // 
            this.lbpodeps.FormattingEnabled = true;
            this.lbpodeps.ItemHeight = 16;
            this.lbpodeps.Location = new System.Drawing.Point(434, 105);
            this.lbpodeps.Name = "lbpodeps";
            this.lbpodeps.Size = new System.Drawing.Size(350, 276);
            this.lbpodeps.TabIndex = 2;
            // 
            // tbpodname
            // 
            this.tbpodname.Location = new System.Drawing.Point(13, 30);
            this.tbpodname.Name = "tbpodname";
            this.tbpodname.Size = new System.Drawing.Size(282, 22);
            this.tbpodname.TabIndex = 3;
            // 
            // tbpoddesc
            // 
            this.tbpoddesc.Location = new System.Drawing.Point(804, 136);
            this.tbpoddesc.Name = "tbpoddesc";
            this.tbpoddesc.ReadOnly = true;
            this.tbpoddesc.Size = new System.Drawing.Size(343, 95);
            this.tbpoddesc.TabIndex = 4;
            this.tbpoddesc.Text = "";
            // 
            // tbepdesc
            // 
            this.tbepdesc.Location = new System.Drawing.Point(804, 286);
            this.tbepdesc.Name = "tbepdesc";
            this.tbepdesc.ReadOnly = true;
            this.tbepdesc.Size = new System.Drawing.Size(343, 95);
            this.tbepdesc.TabIndex = 5;
            this.tbepdesc.Text = "";
            // 
            // lblpoddesc
            // 
            this.lblpoddesc.AutoSize = true;
            this.lblpoddesc.Location = new System.Drawing.Point(801, 105);
            this.lblpoddesc.Name = "lblpoddesc";
            this.lblpoddesc.Size = new System.Drawing.Size(132, 17);
            this.lblpoddesc.TabIndex = 6;
            this.lblpoddesc.Text = "Podcast description";
            // 
            // lblepdesc
            // 
            this.lblepdesc.AutoSize = true;
            this.lblepdesc.Location = new System.Drawing.Point(801, 254);
            this.lblepdesc.Name = "lblepdesc";
            this.lblepdesc.Size = new System.Drawing.Size(132, 17);
            this.lblepdesc.TabIndex = 7;
            this.lblepdesc.Text = "Episode description";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 17);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Name";
            // 
            // lblurl
            // 
            this.lblurl.AutoSize = true;
            this.lblurl.Location = new System.Drawing.Point(12, 55);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(26, 17);
            this.lblurl.TabIndex = 9;
            this.lblurl.Text = "Url";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 545);
            this.Controls.Add(this.lblurl);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblepdesc);
            this.Controls.Add(this.lblpoddesc);
            this.Controls.Add(this.tbepdesc);
            this.Controls.Add(this.tbpoddesc);
            this.Controls.Add(this.tbpodname);
            this.Controls.Add(this.lbpodeps);
            this.Controls.Add(this.tbpodurl);
            this.Controls.Add(this.btnaddrss);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddrss;
        private System.Windows.Forms.TextBox tbpodurl;
        private System.Windows.Forms.ListBox lbpodeps;
        private System.Windows.Forms.TextBox tbpodname;
        private System.Windows.Forms.RichTextBox tbpoddesc;
        private System.Windows.Forms.RichTextBox tbepdesc;
        private System.Windows.Forms.Label lblpoddesc;
        private System.Windows.Forms.Label lblepdesc;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblurl;
    }
}

