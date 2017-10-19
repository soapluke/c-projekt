namespace GUI
{
    partial class AddRemoveCategory
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
            this.lblnamenewcat = new System.Windows.Forms.Label();
            this.lbldeletecat = new System.Windows.Forms.Label();
            this.btndeletecat = new System.Windows.Forms.Button();
            this.cbcattodelete = new System.Windows.Forms.ComboBox();
            this.tbnamenewcat = new System.Windows.Forms.TextBox();
            this.btnaddnewcat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnamenewcat
            // 
            this.lblnamenewcat.AutoSize = true;
            this.lblnamenewcat.Location = new System.Drawing.Point(12, 9);
            this.lblnamenewcat.Name = "lblnamenewcat";
            this.lblnamenewcat.Size = new System.Drawing.Size(133, 17);
            this.lblnamenewcat.TabIndex = 0;
            this.lblnamenewcat.Text = "Name new category";
            // 
            // lbldeletecat
            // 
            this.lbldeletecat.AutoSize = true;
            this.lbldeletecat.Location = new System.Drawing.Point(12, 109);
            this.lbldeletecat.Name = "lbldeletecat";
            this.lbldeletecat.Size = new System.Drawing.Size(108, 17);
            this.lbldeletecat.TabIndex = 1;
            this.lbldeletecat.Text = "Delete category";
            // 
            // btndeletecat
            // 
            this.btndeletecat.Location = new System.Drawing.Point(166, 138);
            this.btndeletecat.Name = "btndeletecat";
            this.btndeletecat.Size = new System.Drawing.Size(75, 23);
            this.btndeletecat.TabIndex = 2;
            this.btndeletecat.Text = "Delete";
            this.btndeletecat.UseVisualStyleBackColor = true;
            // 
            // cbcattodelete
            // 
            this.cbcattodelete.FormattingEnabled = true;
            this.cbcattodelete.Location = new System.Drawing.Point(15, 135);
            this.cbcattodelete.Name = "cbcattodelete";
            this.cbcattodelete.Size = new System.Drawing.Size(121, 24);
            this.cbcattodelete.TabIndex = 3;
            // 
            // tbnamenewcat
            // 
            this.tbnamenewcat.Location = new System.Drawing.Point(15, 39);
            this.tbnamenewcat.Name = "tbnamenewcat";
            this.tbnamenewcat.Size = new System.Drawing.Size(121, 22);
            this.tbnamenewcat.TabIndex = 4;
            // 
            // btnaddnewcat
            // 
            this.btnaddnewcat.Location = new System.Drawing.Point(166, 38);
            this.btnaddnewcat.Name = "btnaddnewcat";
            this.btnaddnewcat.Size = new System.Drawing.Size(75, 23);
            this.btnaddnewcat.TabIndex = 5;
            this.btnaddnewcat.Text = "Add";
            this.btnaddnewcat.UseVisualStyleBackColor = true;
            this.btnaddnewcat.Click += new System.EventHandler(this.btnaddnewcat_Click);
            // 
            // AddRemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 204);
            this.Controls.Add(this.btnaddnewcat);
            this.Controls.Add(this.tbnamenewcat);
            this.Controls.Add(this.cbcattodelete);
            this.Controls.Add(this.btndeletecat);
            this.Controls.Add(this.lbldeletecat);
            this.Controls.Add(this.lblnamenewcat);
            this.Name = "AddRemoveCategory";
            this.Text = "AddRemoveCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnamenewcat;
        private System.Windows.Forms.Label lbldeletecat;
        private System.Windows.Forms.Button btndeletecat;
        private System.Windows.Forms.TextBox tbnamenewcat;
        private System.Windows.Forms.Button btnaddnewcat;
        internal System.Windows.Forms.ComboBox cbcattodelete;
    }
}