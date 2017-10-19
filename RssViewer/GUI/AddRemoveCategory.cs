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
    public partial class AddRemoveCategory : Form1
    {
        Category addnew = new Category();
       
        public AddRemoveCategory()
        {
            InitializeComponent();
            base.FillCategoryCb();
        }

        private void btnaddnewcat_Click(object sender, EventArgs e)
        {
            addnew.NewFolder(tbnamenewcat.Text);
            addnew.AddNewCategory(tbnamenewcat.Text);

        }
    }
}
