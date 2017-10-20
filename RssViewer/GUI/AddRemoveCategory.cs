using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using System.IO;

namespace GUI
{
    public partial class AddRemoveCategory : Form
    {
        Category category = new Category();
        private readonly Form1 mainwindow;

        public AddRemoveCategory(Form1 mainwindow)
        {
            InitializeComponent();
            this.mainwindow = mainwindow;
        }

        private void AddRemoveCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btnaddnewcat_Click(object sender, EventArgs e)
        {
            category.NewFolder(tbnamenewcat.Text);
            MessageBox.Show($"The category {tbnamenewcat.Text} has been added.");
            mainwindow.FillCategoryCb();

        }

        private void btnremovecat_Click(object sender, EventArgs e)
        {
            string chosencategory = cbchoosecattoremove.SelectedItem.ToString();
            DialogResult yesno = MessageBox.Show($"Are you sure you want to delete {chosencategory}?", "Confirm delete", MessageBoxButtons.YesNo);

            if (yesno == DialogResult.Yes)
            {
                category.RemoveCategory(chosencategory);
                mainwindow.FillCategoryCb();
            }
        }
    }
}
