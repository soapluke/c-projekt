﻿namespace GUI
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
            this.btnaddrss = new System.Windows.Forms.Button();
            this.tbpodurl = new System.Windows.Forms.TextBox();
            this.lbpodeps = new System.Windows.Forms.ListBox();
            this.tbpodname = new System.Windows.Forms.TextBox();
            this.tbepdesc = new System.Windows.Forms.RichTextBox();
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
            this.mediaplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnplaypodcast = new System.Windows.Forms.Button();
            this.cbchooseinterval = new System.Windows.Forms.ComboBox();
            this.lblchooseinterval = new System.Windows.Forms.Label();
            this.lblepname = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblinterval = new System.Windows.Forms.Label();
            this.lbllastsynced = new System.Windows.Forms.Label();
            this.lblepnameempty = new System.Windows.Forms.Label();
            this.lblstatusempty = new System.Windows.Forms.Label();
            this.lblintervalempty = new System.Windows.Forms.Label();
            this.lbllastsyncedempty = new System.Windows.Forms.Label();
            this.btnmovepodcast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddrss
            // 
            this.btnaddrss.Location = new System.Drawing.Point(13, 270);
            this.btnaddrss.Name = "btnaddrss";
            this.btnaddrss.Size = new System.Drawing.Size(148, 35);
            this.btnaddrss.TabIndex = 0;
            this.btnaddrss.Text = "Add podcast";
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
            // tbepdesc
            // 
            this.tbepdesc.Location = new System.Drawing.Point(804, 131);
            this.tbepdesc.Name = "tbepdesc";
            this.tbepdesc.ReadOnly = true;
            this.tbepdesc.Size = new System.Drawing.Size(343, 95);
            this.tbepdesc.TabIndex = 5;
            this.tbepdesc.Text = "";
            // 
            // lblepdesc
            // 
            this.lblepdesc.AutoSize = true;
            this.lblepdesc.Location = new System.Drawing.Point(801, 105);
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
            this.btndeletepod.Location = new System.Drawing.Point(1018, 392);
            this.btndeletepod.Name = "btndeletepod";
            this.btndeletepod.Size = new System.Drawing.Size(129, 38);
            this.btndeletepod.TabIndex = 17;
            this.btndeletepod.Text = "Delete podcast";
            this.btndeletepod.UseVisualStyleBackColor = true;
            this.btndeletepod.Click += new System.EventHandler(this.btndeletepod_Click);
            // 
            // mediaplayer
            // 
            this.mediaplayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaplayer.Enabled = true;
            this.mediaplayer.Location = new System.Drawing.Point(1, 509);
            this.mediaplayer.Name = "mediaplayer";
            this.mediaplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaplayer.OcxState")));
            this.mediaplayer.Size = new System.Drawing.Size(1170, 45);
            this.mediaplayer.TabIndex = 18;
            // 
            // btnplaypodcast
            // 
            this.btnplaypodcast.Location = new System.Drawing.Point(1018, 304);
            this.btnplaypodcast.Name = "btnplaypodcast";
            this.btnplaypodcast.Size = new System.Drawing.Size(129, 38);
            this.btnplaypodcast.TabIndex = 19;
            this.btnplaypodcast.Text = "Play podcast";
            this.btnplaypodcast.UseVisualStyleBackColor = true;
            this.btnplaypodcast.Click += new System.EventHandler(this.btnplaypodcast_Click);
            // 
            // cbchooseinterval
            // 
            this.cbchooseinterval.FormattingEnabled = true;
            this.cbchooseinterval.Location = new System.Drawing.Point(15, 217);
            this.cbchooseinterval.Name = "cbchooseinterval";
            this.cbchooseinterval.Size = new System.Drawing.Size(146, 24);
            this.cbchooseinterval.TabIndex = 20;
            // 
            // lblchooseinterval
            // 
            this.lblchooseinterval.AutoSize = true;
            this.lblchooseinterval.Location = new System.Drawing.Point(12, 197);
            this.lblchooseinterval.Name = "lblchooseinterval";
            this.lblchooseinterval.Size = new System.Drawing.Size(106, 17);
            this.lblchooseinterval.TabIndex = 21;
            this.lblchooseinterval.Text = "Choose interval";
            // 
            // lblepname
            // 
            this.lblepname.AutoSize = true;
            this.lblepname.Location = new System.Drawing.Point(804, 233);
            this.lblepname.Name = "lblepname";
            this.lblepname.Size = new System.Drawing.Size(102, 17);
            this.lblepname.TabIndex = 22;
            this.lblepname.Text = "Episode name:";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(804, 261);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(52, 17);
            this.lblstatus.TabIndex = 23;
            this.lblstatus.Text = "Status:";
            // 
            // lblinterval
            // 
            this.lblinterval.AutoSize = true;
            this.lblinterval.Location = new System.Drawing.Point(804, 47);
            this.lblinterval.Name = "lblinterval";
            this.lblinterval.Size = new System.Drawing.Size(58, 17);
            this.lblinterval.TabIndex = 24;
            this.lblinterval.Text = "Interval:";
            // 
            // lbllastsynced
            // 
            this.lbllastsynced.AutoSize = true;
            this.lbllastsynced.Location = new System.Drawing.Point(804, 18);
            this.lbllastsynced.Name = "lbllastsynced";
            this.lbllastsynced.Size = new System.Drawing.Size(88, 17);
            this.lbllastsynced.TabIndex = 25;
            this.lbllastsynced.Text = "Last synced:";
            // 
            // lblepnameempty
            // 
            this.lblepnameempty.AutoSize = true;
            this.lblepnameempty.Location = new System.Drawing.Point(928, 233);
            this.lblepnameempty.Name = "lblepnameempty";
            this.lblepnameempty.Size = new System.Drawing.Size(0, 17);
            this.lblepnameempty.TabIndex = 26;
            // 
            // lblstatusempty
            // 
            this.lblstatusempty.AutoSize = true;
            this.lblstatusempty.Location = new System.Drawing.Point(928, 261);
            this.lblstatusempty.Name = "lblstatusempty";
            this.lblstatusempty.Size = new System.Drawing.Size(0, 17);
            this.lblstatusempty.TabIndex = 27;
            // 
            // lblintervalempty
            // 
            this.lblintervalempty.AutoSize = true;
            this.lblintervalempty.Location = new System.Drawing.Point(928, 47);
            this.lblintervalempty.Name = "lblintervalempty";
            this.lblintervalempty.Size = new System.Drawing.Size(0, 17);
            this.lblintervalempty.TabIndex = 28;
            // 
            // lbllastsyncedempty
            // 
            this.lbllastsyncedempty.AutoSize = true;
            this.lbllastsyncedempty.Location = new System.Drawing.Point(928, 18);
            this.lbllastsyncedempty.Name = "lbllastsyncedempty";
            this.lbllastsyncedempty.Size = new System.Drawing.Size(0, 17);
            this.lbllastsyncedempty.TabIndex = 29;
            // 
            // btnmovepodcast
            // 
            this.btnmovepodcast.Location = new System.Drawing.Point(1018, 348);
            this.btnmovepodcast.Name = "btnmovepodcast";
            this.btnmovepodcast.Size = new System.Drawing.Size(129, 38);
            this.btnmovepodcast.TabIndex = 30;
            this.btnmovepodcast.Text = "Change podcast";
            this.btnmovepodcast.UseVisualStyleBackColor = true;
            this.btnmovepodcast.Click += new System.EventHandler(this.btnmovepodcast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 701);
            this.Controls.Add(this.btnmovepodcast);
            this.Controls.Add(this.lbllastsyncedempty);
            this.Controls.Add(this.lblintervalempty);
            this.Controls.Add(this.lblstatusempty);
            this.Controls.Add(this.lblepnameempty);
            this.Controls.Add(this.lbllastsynced);
            this.Controls.Add(this.lblinterval);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblepname);
            this.Controls.Add(this.lblchooseinterval);
            this.Controls.Add(this.cbchooseinterval);
            this.Controls.Add(this.btnplaypodcast);
            this.Controls.Add(this.mediaplayer);
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
            this.Controls.Add(this.tbepdesc);
            this.Controls.Add(this.tbpodname);
            this.Controls.Add(this.lbpodeps);
            this.Controls.Add(this.tbpodurl);
            this.Controls.Add(this.btnaddrss);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mediaplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddrss;
        private System.Windows.Forms.TextBox tbpodurl;
        private System.Windows.Forms.ListBox lbpodeps;
        private System.Windows.Forms.TextBox tbpodname;
        private System.Windows.Forms.RichTextBox tbepdesc;
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
        private AxWMPLib.AxWindowsMediaPlayer mediaplayer;
        private System.Windows.Forms.Button btnplaypodcast;
        private System.Windows.Forms.ComboBox cbchooseinterval;
        private System.Windows.Forms.Label lblchooseinterval;
        private System.Windows.Forms.Label lblepname;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblinterval;
        private System.Windows.Forms.Label lbllastsynced;
        private System.Windows.Forms.Label lblepnameempty;
        private System.Windows.Forms.Label lblstatusempty;
        private System.Windows.Forms.Label lblintervalempty;
        private System.Windows.Forms.Label lbllastsyncedempty;
        private System.Windows.Forms.Button btnmovepodcast;
    }
}

