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
using WMPLib;

namespace GUI
{
    public partial class Form1 : Form
    {
        AddRemoveCategory addremove;
        Feed feed = new Feed();
        ChangePod changepod = new ChangePod();
        PlayPodcast playpod = new PlayPodcast();
        public List<String> podList = new List<String>();

        public Form1()
        {
            InitializeComponent();
            addremove = new AddRemoveCategory(this);
            FillCategoryCb();
            FillIntervalCb();
        }

        private async void btnaddrss_Click(object sender, EventArgs e)
        {
            if(Validation.CheckIfEmpty(tbpodname, "podcast name") && Validation.CheckIfEmpty(tbpodurl, "podcast URL") && Validation.CheckIfCorrectUrl(tbpodurl) && Validation.CheckIfEmpty(cbchoosecategory, "a category") && Validation.CheckIfEmpty(cbchooseinterval, "an update interval"))
            {
                string name = tbpodname.Text;
                string category = cbchoosecategory.SelectedItem.ToString();
                await AddPodCastAsync();
                ClearAllAddPod();
                MessageBox.Show($"'{name}' has been added to the '{category}' category.");
            }
        }

        public async Task AddPodCastAsync()
        {
            feed.GetAddNewPod(tbpodname.Text, tbpodurl.Text, cbchoosecategory.SelectedItem.ToString(), feed.GetInterval(cbchooseinterval));
            lbpodeps.Items.Clear();
            await Task.CompletedTask;
        }
        //Knapp för att öppna AddRemoveCategory.
        private void button1_Click(object sender, EventArgs e)
        {
            addremove.Show();
        }

        public virtual void FillCategoryCb()
        {
            changepod.cbmovecat.Items.Clear();
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
                changepod.cbmovecat.Items.Add(oneCategory);
            }
        }

        public void FillPodcastCb(ComboBox category, ComboBox podcasts)
        {
            podcasts.Text = "";
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

        public void FillIntervalCb()
        {
            cbchooseinterval.Items.Add("One hour.");
            cbchooseinterval.Items.Add("Two hours.");
            cbchooseinterval.Items.Add("Six hours.");
            cbchooseinterval.Items.Add("Twelve hours.");
            changepod.cbchangeinterval.Items.Add("One hour.");
            changepod.cbchangeinterval.Items.Add("Two hours.");
            changepod.cbchangeinterval.Items.Add("Six hours.");
            changepod.cbchangeinterval.Items.Add("Twelve hours.");
        }

        private void ClearAllPodInfo()
        {
            lblintervalempty.Text = "";
            lblepnameempty.Text = "";
            lbllastsyncedempty.Text = "";
            lblstatusempty.Text = "";
            lbpodeps.Items.Clear();
            tbepdesc.Text = "";
        }

        private void ClearAllAddPod()
        {
            tbpodname.Text = "";
            tbpodurl.Text = "";
            cbchoosecategory.Text = "";
            cbchooseinterval.Text = "";
        }

        private void cbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllPodInfo();
            FillPodcastCb(cbcategory, cbpodcasts);
        }

        private void cbchoosecategory_MouseClick(object sender, MouseEventArgs e)
        {
            FillCategoryCb();
        }

        private void cbpodcasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllPodInfo();
            feed.GetEpisodes(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString(), lbpodeps);
            feed.GetPodcastInfo(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString(), lbllastsyncedempty, lblintervalempty);
        }

        private void lbpodeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            feed.GetEpisodeDescription(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString(), lbpodeps.SelectedItem.ToString(), tbepdesc);
            feed.GetEpisodeInfo(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString(), lbpodeps.SelectedItem.ToString(), lblepnameempty, lblstatusempty);
        }

        private void cbcategory_MouseClick(object sender, MouseEventArgs e)
        {
            FillCategoryCb();
        }

        private void btndeletepod_Click(object sender, EventArgs e)
        {
            if (Validation.CheckIfEmpty(cbcategory, "a category") && Validation.CheckIfEmpty(cbpodcasts, "a podcast"))
            {
                string chosenpodcast = cbpodcasts.SelectedItem.ToString();
                DialogResult yesno = MessageBox.Show($"Are you sure you want to delete {chosenpodcast}?", "Confirm delete", MessageBoxButtons.YesNo);

                if (yesno == DialogResult.Yes)
                {
                    feed.GetDeletePod(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString());
                    cbpodcasts.Text = "";
                    lbpodeps.Items.Clear();
                    tbepdesc.Clear();
                }
            }
        }

        private void btnplaypodcast_Click(object sender, EventArgs e)
        {
            if (Validation.CheckIfEmpty(cbcategory, "a category") && Validation.CheckIfEmpty(cbpodcasts, "a podcast") && Validation.CheckIfEmpty(lbpodeps))
            {
                string url;
                playpod.GetPodUrl(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString(), lbpodeps.SelectedItem.ToString(), out url);
                mediaplayer.URL = url;
            }
        }

        private void btnmovepodcast_Click(object sender, EventArgs e)
        {
            if (Validation.CheckIfEmpty(cbcategory, "a category") && Validation.CheckIfEmpty(cbpodcasts, "a podcast"))
            {
                changepod = new ChangePod(cbcategory.SelectedItem.ToString(), cbpodcasts.SelectedItem.ToString());
                changepod.Show();
                FillCategoryCb();
                FillIntervalCb();
                changepod.lblmovepodcast.Text = $"Select which category you want to move {cbpodcasts.SelectedItem.ToString()} to.";
                changepod.lblchangeinterval.Text = $"Select another update interval for {cbpodcasts.SelectedItem.ToString()}.";
            }
        }
    }
}
