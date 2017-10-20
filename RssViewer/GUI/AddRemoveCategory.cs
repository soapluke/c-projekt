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

namespace GUI
{
    public partial class AddRemoveCategory : Form
    {
        Category category = new Category();

        public AddRemoveCategory()
        {
            InitializeComponent();
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
        }
    }
}
