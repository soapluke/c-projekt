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
    public partial class ChangePod : Form
    {
        Category category = new Category();
        Feed feed = new Feed();
        public string categoryname = "";
        public string podname = "";

        public ChangePod(string categoryname, string podname)
        {
            this.categoryname = categoryname;
            this.podname = podname;
            InitializeComponent();
        }

        public ChangePod()
        {
            InitializeComponent();
        }

        private void btnmovepodcast_Click(object sender, EventArgs e)
        {
            if(Validation.CheckIfEmpty(cbmovecat, "a category")) {
                category.GetMovePod(categoryname, cbmovecat.SelectedItem.ToString(), podname);
                MessageBox.Show($"The podcast '{podname}' has been moved to category '{cbmovecat.SelectedItem.ToString()}'.");
                this.Hide();
            }
        }

        private void btnchangeinterval_Click(object sender, EventArgs e)
        {
            if(Validation.CheckIfEmpty(cbchangeinterval, "an update interval"))
            {
                feed.GetChangeInterval(categoryname, podname, cbchangeinterval);
                MessageBox.Show($"The podcast has changed interval to {cbchangeinterval.SelectedItem.ToString()}");
                this.Hide();
            }
        }
    }
}
