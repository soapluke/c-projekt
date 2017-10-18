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
            this.lbpods = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnaddrss
            // 
            this.btnaddrss.Location = new System.Drawing.Point(312, 12);
            this.btnaddrss.Name = "btnaddrss";
            this.btnaddrss.Size = new System.Drawing.Size(75, 23);
            this.btnaddrss.TabIndex = 0;
            this.btnaddrss.Text = "Add Pod";
            this.btnaddrss.UseVisualStyleBackColor = true;
            this.btnaddrss.Click += new System.EventHandler(this.btnaddrss_Click);
            // 
            // tbpodurl
            // 
            this.tbpodurl.Location = new System.Drawing.Point(12, 12);
            this.tbpodurl.Name = "tbpodurl";
            this.tbpodurl.Size = new System.Drawing.Size(283, 22);
            this.tbpodurl.TabIndex = 1;
            // 
            // lbpods
            // 
            this.lbpods.FormattingEnabled = true;
            this.lbpods.ItemHeight = 16;
            this.lbpods.Location = new System.Drawing.Point(13, 50);
            this.lbpods.Name = "lbpods";
            this.lbpods.Size = new System.Drawing.Size(374, 420);
            this.lbpods.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 545);
            this.Controls.Add(this.lbpods);
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
        private System.Windows.Forms.ListBox lbpods;
    }
}

