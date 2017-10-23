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
            this.cbchoosecategory = new System.Windows.Forms.ComboBox();
            this.lblchoosecategory = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.cbpodcasts = new System.Windows.Forms.ComboBox();
            this.lblpodcasts = new System.Windows.Forms.Label();
            this.btndeletepod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaddrss
            // 
            this.btnaddrss.Location = new System.Drawing.Point(13, 286);
            this.btnaddrss.Name = "btnaddrss";
            this.btnaddrss.Size = new System.Drawing.Size(83, 23);
            this.btnaddrss.TabIndex = 0;
            this.btnaddrss.Text = "Add Pod";
            this.btnaddrss.UseVisualStyleBackColor = true;
            this.btnaddrss.Click += new System.EventHandler(this.btnaddrss_Click);
            // 
            // tbpodurl
            // 
            this.tbpodurl.Location = new System.Drawing.Point(13, 91);
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
            this.lbpodeps.SelectedIndexChanged += new System.EventHandler(this.lbpodeps_SelectedIndexChanged);
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
            this.lblurl.Location = new System.Drawing.Point(10, 71);
            this.lblurl.Name = "lblurl";
            this.lblurl.Size = new System.Drawing.Size(26, 17);
            this.lblurl.TabIndex = 9;
            this.lblurl.Text = "Url";
            // 
            // cbchoosecategory
            // 
            this.cbchoosecategory.FormattingEnabled = true;
            this.cbchoosecategory.Location = new System.Drawing.Point(15, 151);
            this.cbchoosecategory.Name = "cbchoosecategory";
            this.cbchoosecategory.Size = new System.Drawing.Size(146, 24);
            this.cbchoosecategory.TabIndex = 10;
            this.cbchoosecategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbchoosecategory_MouseClick);
            // 
            // lblchoosecategory
            // 
            this.lblchoosecategory.AutoSize = true;
            this.lblchoosecategory.Location = new System.Drawing.Point(12, 131);
            this.lblchoosecategory.Name = "lblchoosecategory";
            this.lblchoosecategory.Size = new System.Drawing.Size(115, 17);
            this.lblchoosecategory.TabIndex = 11;
            this.lblchoosecategory.Text = "Choose category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add/Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbcategory
            // 
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(434, 47);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(146, 24);
            this.cbcategory.TabIndex = 13;
            this.cbcategory.SelectedIndexChanged += new System.EventHandler(this.cbcategory_SelectedIndexChanged);
            this.cbcategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbcategory_MouseClick);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(431, 18);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(65, 17);
            this.lblcategory.TabIndex = 14;
            this.lblcategory.Text = "Category";
            // 
            // cbpodcasts
            // 
            this.cbpodcasts.FormattingEnabled = true;
            this.cbpodcasts.Location = new System.Drawing.Point(638, 47);
            this.cbpodcasts.Name = "cbpodcasts";
            this.cbpodcasts.Size = new System.Drawing.Size(146, 24);
            this.cbpodcasts.TabIndex = 15;
            this.cbpodcasts.SelectedIndexChanged += new System.EventHandler(this.cbpodcasts_SelectedIndexChanged);
            // 
            // lblpodcasts
            // 
            this.lblpodcasts.AutoSize = true;
            this.lblpodcasts.Location = new System.Drawing.Point(635, 18);
            this.lblpodcasts.Name = "lblpodcasts";
            this.lblpodcasts.Size = new System.Drawing.Size(66, 17);
            this.lblpodcasts.TabIndex = 16;
            this.lblpodcasts.Text = "Podcasts";
            // 
            // btndeletepod
            // 
            this.btndeletepod.Location = new System.Drawing.Point(804, 401);
            this.btndeletepod.Name = "btndeletepod";
            this.btndeletepod.Size = new System.Drawing.Size(129, 30);
            this.btndeletepod.TabIndex = 17;
            this.btndeletepod.Text = "Delete podcast";
            this.btndeletepod.UseVisualStyleBackColor = true;
            this.btndeletepod.Click += new System.EventHandler(this.btndeletepod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 545);
            this.Controls.Add(this.btndeletepod);
            this.Controls.Add(this.lblpodcasts);
            this.Controls.Add(this.cbpodcasts);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.cbcategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblchoosecategory);
            this.Controls.Add(this.cbchoosecategory);
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
        private System.Windows.Forms.ComboBox cbchoosecategory;
        private System.Windows.Forms.Label lblchoosecategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.ComboBox cbpodcasts;
        private System.Windows.Forms.Label lblpodcasts;
        private System.Windows.Forms.Button btndeletepod;
    }
}

