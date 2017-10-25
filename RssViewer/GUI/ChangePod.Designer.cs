namespace GUI
{
    partial class ChangePod
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
            this.lblmovepodcast = new System.Windows.Forms.Label();
            this.cbmovecat = new System.Windows.Forms.ComboBox();
            this.btnmovepodcast = new System.Windows.Forms.Button();
            this.cbchangeinterval = new System.Windows.Forms.ComboBox();
            this.btnchangeinterval = new System.Windows.Forms.Button();
            this.lblchangeinterval = new System.Windows.Forms.Label();
            this.tbchangeurl = new System.Windows.Forms.TextBox();
            this.btchangeurl = new System.Windows.Forms.Button();
            this.lblchangeurl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmovepodcast
            // 
            this.lblmovepodcast.AutoSize = true;
            this.lblmovepodcast.Location = new System.Drawing.Point(26, 25);
            this.lblmovepodcast.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblmovepodcast.Name = "lblmovepodcast";
            this.lblmovepodcast.Size = new System.Drawing.Size(0, 32);
            this.lblmovepodcast.TabIndex = 0;
            // 
            // cbmovecat
            // 
            this.cbmovecat.FormattingEnabled = true;
            this.cbmovecat.Location = new System.Drawing.Point(158, 112);
            this.cbmovecat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbmovecat.Name = "cbmovecat";
            this.cbmovecat.Size = new System.Drawing.Size(238, 39);
            this.cbmovecat.TabIndex = 1;
            // 
            // btnmovepodcast
            // 
            this.btnmovepodcast.Location = new System.Drawing.Point(502, 110);
            this.btnmovepodcast.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnmovepodcast.Name = "btnmovepodcast";
            this.btnmovepodcast.Size = new System.Drawing.Size(150, 46);
            this.btnmovepodcast.TabIndex = 2;
            this.btnmovepodcast.Text = "Move";
            this.btnmovepodcast.UseVisualStyleBackColor = true;
            this.btnmovepodcast.Click += new System.EventHandler(this.btnmovepodcast_Click);
            // 
            // cbchangeinterval
            // 
            this.cbchangeinterval.FormattingEnabled = true;
            this.cbchangeinterval.Location = new System.Drawing.Point(158, 250);
            this.cbchangeinterval.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbchangeinterval.Name = "cbchangeinterval";
            this.cbchangeinterval.Size = new System.Drawing.Size(238, 39);
            this.cbchangeinterval.TabIndex = 3;
            // 
            // btnchangeinterval
            // 
            this.btnchangeinterval.Location = new System.Drawing.Point(502, 248);
            this.btnchangeinterval.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnchangeinterval.Name = "btnchangeinterval";
            this.btnchangeinterval.Size = new System.Drawing.Size(150, 46);
            this.btnchangeinterval.TabIndex = 4;
            this.btnchangeinterval.Text = "Change";
            this.btnchangeinterval.UseVisualStyleBackColor = true;
            this.btnchangeinterval.Click += new System.EventHandler(this.btnchangeinterval_Click);
            // 
            // lblchangeinterval
            // 
            this.lblchangeinterval.AutoSize = true;
            this.lblchangeinterval.Location = new System.Drawing.Point(24, 184);
            this.lblchangeinterval.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblchangeinterval.Name = "lblchangeinterval";
            this.lblchangeinterval.Size = new System.Drawing.Size(0, 32);
            this.lblchangeinterval.TabIndex = 5;
            // 
            // tbchangeurl
            // 
            this.tbchangeurl.Location = new System.Drawing.Point(158, 390);
            this.tbchangeurl.Name = "tbchangeurl";
            this.tbchangeurl.Size = new System.Drawing.Size(238, 38);
            this.tbchangeurl.TabIndex = 6;
            // 
            // btchangeurl
            // 
            this.btchangeurl.Location = new System.Drawing.Point(502, 382);
            this.btchangeurl.Margin = new System.Windows.Forms.Padding(6);
            this.btchangeurl.Name = "btchangeurl";
            this.btchangeurl.Size = new System.Drawing.Size(150, 46);
            this.btchangeurl.TabIndex = 7;
            this.btchangeurl.Text = "Change URL";
            this.btchangeurl.UseVisualStyleBackColor = true;
            this.btchangeurl.Click += new System.EventHandler(this.btchangeurl_Click);
            // 
            // lblchangeurl
            // 
            this.lblchangeurl.AutoSize = true;
            this.lblchangeurl.Location = new System.Drawing.Point(26, 338);
            this.lblchangeurl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblchangeurl.Name = "lblchangeurl";
            this.lblchangeurl.Size = new System.Drawing.Size(0, 32);
            this.lblchangeurl.TabIndex = 8;
            // 
            // ChangePod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 489);
            this.Controls.Add(this.lblchangeurl);
            this.Controls.Add(this.btchangeurl);
            this.Controls.Add(this.tbchangeurl);
            this.Controls.Add(this.lblchangeinterval);
            this.Controls.Add(this.btnchangeinterval);
            this.Controls.Add(this.cbchangeinterval);
            this.Controls.Add(this.btnmovepodcast);
            this.Controls.Add(this.cbmovecat);
            this.Controls.Add(this.lblmovepodcast);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ChangePod";
            this.Text = "MovePodcast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnmovepodcast;
        internal System.Windows.Forms.ComboBox cbmovecat;
        internal System.Windows.Forms.Label lblmovepodcast;
        internal System.Windows.Forms.ComboBox cbchangeinterval;
        private System.Windows.Forms.Button btnchangeinterval;
        internal System.Windows.Forms.Label lblchangeinterval;
        private System.Windows.Forms.TextBox tbchangeurl;
        private System.Windows.Forms.Button btchangeurl;
        internal System.Windows.Forms.Label lblchangeurl;
    }
}