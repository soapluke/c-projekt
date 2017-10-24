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
            this.tbnamenewcat = new System.Windows.Forms.TextBox();
            this.lblchoosecattoremove = new System.Windows.Forms.Label();
            this.cbchoosecattoremove = new System.Windows.Forms.ComboBox();
            this.btnaddnewcat = new System.Windows.Forms.Button();
            this.btnremovecat = new System.Windows.Forms.Button();
            this.btnchangecatname = new System.Windows.Forms.Button();
            this.tbchangecatname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnamenewcat
            // 
            this.lblnamenewcat.AutoSize = true;
            this.lblnamenewcat.Location = new System.Drawing.Point(13, 22);
            this.lblnamenewcat.Name = "lblnamenewcat";
            this.lblnamenewcat.Size = new System.Drawing.Size(133, 17);
            this.lblnamenewcat.TabIndex = 0;
            this.lblnamenewcat.Text = "Name new category";
            // 
            // tbnamenewcat
            // 
            this.tbnamenewcat.Location = new System.Drawing.Point(16, 54);
            this.tbnamenewcat.Name = "tbnamenewcat";
            this.tbnamenewcat.Size = new System.Drawing.Size(160, 22);
            this.tbnamenewcat.TabIndex = 1;
            // 
            // lblchoosecattoremove
            // 
            this.lblchoosecattoremove.AutoSize = true;
            this.lblchoosecattoremove.Location = new System.Drawing.Point(12, 115);
            this.lblchoosecattoremove.Name = "lblchoosecattoremove";
            this.lblchoosecattoremove.Size = new System.Drawing.Size(250, 17);
            this.lblchoosecattoremove.TabIndex = 2;
            this.lblchoosecattoremove.Text = "Choose category to remove or change";
            // 
            // cbchoosecattoremove
            // 
            this.cbchoosecattoremove.FormattingEnabled = true;
            this.cbchoosecattoremove.Location = new System.Drawing.Point(15, 149);
            this.cbchoosecattoremove.Name = "cbchoosecattoremove";
            this.cbchoosecattoremove.Size = new System.Drawing.Size(161, 24);
            this.cbchoosecattoremove.TabIndex = 3;
            // 
            // btnaddnewcat
            // 
            this.btnaddnewcat.Location = new System.Drawing.Point(217, 54);
            this.btnaddnewcat.Name = "btnaddnewcat";
            this.btnaddnewcat.Size = new System.Drawing.Size(89, 23);
            this.btnaddnewcat.TabIndex = 4;
            this.btnaddnewcat.Text = "Add";
            this.btnaddnewcat.UseVisualStyleBackColor = true;
            this.btnaddnewcat.Click += new System.EventHandler(this.btnaddnewcat_Click);
            // 
            // btnremovecat
            // 
            this.btnremovecat.Location = new System.Drawing.Point(217, 149);
            this.btnremovecat.Name = "btnremovecat";
            this.btnremovecat.Size = new System.Drawing.Size(89, 23);
            this.btnremovecat.TabIndex = 5;
            this.btnremovecat.Text = "Remove";
            this.btnremovecat.UseVisualStyleBackColor = true;
            this.btnremovecat.Click += new System.EventHandler(this.btnremovecat_Click);
            // 
            // btnchangecatname
            // 
            this.btnchangecatname.Location = new System.Drawing.Point(217, 220);
            this.btnchangecatname.Name = "btnchangecatname";
            this.btnchangecatname.Size = new System.Drawing.Size(89, 23);
            this.btnchangecatname.TabIndex = 6;
            this.btnchangecatname.Text = "Change";
            this.btnchangecatname.UseVisualStyleBackColor = true;
            this.btnchangecatname.Click += new System.EventHandler(this.btnchangecatname_Click);
            // 
            // tbchangecatname
            // 
            this.tbchangecatname.Location = new System.Drawing.Point(15, 221);
            this.tbchangecatname.Name = "tbchangecatname";
            this.tbchangecatname.Size = new System.Drawing.Size(161, 22);
            this.tbchangecatname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter new name";
            // 
            // AddRemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbchangecatname);
            this.Controls.Add(this.btnchangecatname);
            this.Controls.Add(this.btnremovecat);
            this.Controls.Add(this.btnaddnewcat);
            this.Controls.Add(this.cbchoosecattoremove);
            this.Controls.Add(this.lblchoosecattoremove);
            this.Controls.Add(this.tbnamenewcat);
            this.Controls.Add(this.lblnamenewcat);
            this.Name = "AddRemoveCategory";
            this.Text = "AddRemoveCategory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRemoveCategory_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnamenewcat;
        private System.Windows.Forms.TextBox tbnamenewcat;
        private System.Windows.Forms.Label lblchoosecattoremove;
        internal System.Windows.Forms.ComboBox cbchoosecattoremove;
        private System.Windows.Forms.Button btnaddnewcat;
        private System.Windows.Forms.Button btnremovecat;
        private System.Windows.Forms.Button btnchangecatname;
        private System.Windows.Forms.TextBox tbchangecatname;
        private System.Windows.Forms.Label label1;
    }
}