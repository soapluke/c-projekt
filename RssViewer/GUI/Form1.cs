using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        AddRemoveCategory addremove = new AddRemoveCategory();
        Feed feed = new Feed();
        public List<String> podList = new List<String>();

        public Form1()
        {
            InitializeComponent();
            FillCategoryCb();

        }

        private async void btnaddrss_Click(object sender, EventArgs e)
        {
            await AddPodCastAsync();
        }

        public async Task AddPodCastAsync()
        {
            feed.GetAddNewPod(tbpodname.Text, tbpodurl.Text, cbchoosecategory.SelectedItem.ToString());
            lbpodeps.Items.Clear();
            await Task.Delay(5000);

        }
        //Knapp för att öppna addRemoveCategory.
        private void button1_Click(object sender, EventArgs e)
        {
            
            addremove.Show();
        }

        public void FillCategoryCb()
        {
            string[] categoryArray = Directory.GetDirectories(Directory.GetCurrentDirectory());

            foreach(String c in categoryArray)
            {
                string[] splitCategories = c.Split('\\');
                int i = splitCategories.Length - 1;
                string oneCategory = splitCategories[i];
                addremove.cbchoosecattoremove.Items.Add(oneCategory);
                cbchoosecategory.Items.Add(oneCategory);
                cbcategory.Items.Add(oneCategory);
            }
        }
    }
}
