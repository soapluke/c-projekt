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
        AddRemoveCategory addremove;
        Feed feed = new Feed();
        public List<String> podList = new List<String>();

        public Form1()
        {
            addremove = new AddRemoveCategory(this);
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
        //Knapp för att öppna AddRemoveCategory.
        private void button1_Click(object sender, EventArgs e)
        {
            addremove.Show();
        }

        public void FillCategoryCb()
        {
            addremove.cbchoosecattoremove.Items.Clear();
            cbchoosecategory.Items.Clear();
            cbcategory.Items.Clear();
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

        public void FillPodcastCb(ComboBox category, ComboBox podcasts)
        {
            podcasts.Items.Clear();
            string categorystring = category.SelectedItem.ToString();
            string[] podcastArray = Directory.GetFiles(categorystring);

            foreach(String p in podcastArray)
            {
                string[] splitPods = p.Split('\\');
                string i = splitPods[splitPods.Length - 1];
                string[] onePod = i.Split('.');
                string pod = onePod[0];

                podcasts.Items.Add(pod);
            }
        }

        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPodcastCb(cbcategory, cbpodcasts);
        }

        private void cbchoosecategory_MouseClick(object sender, MouseEventArgs e)
        {
            FillCategoryCb();
        }

        private void cbpodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            feed.GetEpisodes(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString(), lbpodeps);
            feed.GetPodcastDescription(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString(), tbpoddesc);
        }

        private void lbpodeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            feed.GetEpisodeDescription(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString(), lbpodeps.SelectedItem.ToString(), tbepdesc);
        }

        private void cbcategory_MouseClick(object sender, MouseEventArgs e)
        {
            FillCategoryCb();
        }
    }
}
