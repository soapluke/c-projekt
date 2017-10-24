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
            this.SuspendLayout();
            // 
            // lblmovepodcast
            // 
            this.lblmovepodcast.AutoSize = true;
            this.lblmovepodcast.Location = new System.Drawing.Point(13, 13);
            this.lblmovepodcast.Name = "lblmovepodcast";
            this.lblmovepodcast.Size = new System.Drawing.Size(0, 17);
            this.lblmovepodcast.TabIndex = 0;
            // 
            // cbmovecat
            // 
            this.cbmovecat.FormattingEnabled = true;
            this.cbmovecat.Location = new System.Drawing.Point(79, 58);
            this.cbmovecat.Name = "cbmovecat";
            this.cbmovecat.Size = new System.Drawing.Size(121, 24);
            this.cbmovecat.TabIndex = 1;
            // 
            // btnmovepodcast
            // 
            this.btnmovepodcast.Location = new System.Drawing.Point(251, 57);
            this.btnmovepodcast.Name = "btnmovepodcast";
            this.btnmovepodcast.Size = new System.Drawing.Size(75, 24);
            this.btnmovepodcast.TabIndex = 2;
            this.btnmovepodcast.Text = "Move";
            this.btnmovepodcast.UseVisualStyleBackColor = true;
            this.btnmovepodcast.Click += new System.EventHandler(this.btnmovepodcast_Click);
            // 
            // cbchangeinterval
            // 
            this.cbchangeinterval.FormattingEnabled = true;
            this.cbchangeinterval.Location = new System.Drawing.Point(79, 129);
            this.cbchangeinterval.Name = "cbchangeinterval";
            this.cbchangeinterval.Size = new System.Drawing.Size(121, 24);
            this.cbchangeinterval.TabIndex = 3;
            // 
            // btnchangeinterval
            // 
            this.btnchangeinterval.Location = new System.Drawing.Point(251, 128);
            this.btnchangeinterval.Name = "btnchangeinterval";
            this.btnchangeinterval.Size = new System.Drawing.Size(75, 24);
            this.btnchangeinterval.TabIndex = 4;
            this.btnchangeinterval.Text = "Change";
            this.btnchangeinterval.UseVisualStyleBackColor = true;
            this.btnchangeinterval.Click += new System.EventHandler(this.btnchangeinterval_Click);
            // 
            // lblchangeinterval
            // 
            this.lblchangeinterval.AutoSize = true;
            this.lblchangeinterval.Location = new System.Drawing.Point(12, 95);
            this.lblchangeinterval.Name = "lblchangeinterval";
            this.lblchangeinterval.Size = new System.Drawing.Size(0, 17);
            this.lblchangeinterval.TabIndex = 5;
            // 
            // ChangePod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 197);
            this.Controls.Add(this.lblchangeinterval);
            this.Controls.Add(this.btnchangeinterval);
            this.Controls.Add(this.cbchangeinterval);
            this.Controls.Add(this.btnmovepodcast);
            this.Controls.Add(this.cbmovecat);
            this.Controls.Add(this.lblmovepodcast);
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
    }
}