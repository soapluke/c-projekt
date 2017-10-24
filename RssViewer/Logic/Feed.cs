using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Data;
using System.IO;
using System.Windows.Forms;

namespace Logic
{
    public class Feed
    {
        AddNewPod newPod = new AddNewPod();
        DeletePod delete = new DeletePod();
        ChangePodcast changepod = new ChangePodcast();

        public void GetAddNewPod(string name, string url, string category, string interval)
        {
            newPod.AddNew(name, url, category, interval);
        }

        public void GetEpisodes(string category, string podcast, ListBox avsnitt)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + podcast + @".xml";

            XmlDocument podxml = new XmlDocument();
            podxml.Load(path);

            try
            {
                var url = podxml.SelectSingleNode("channel/url").InnerText;
                int interval;
                DateTime lastSync;
                DateTime.TryParse(podxml.SelectSingleNode("channel/lastSync").InnerText, out lastSync);
                int.TryParse(podxml.SelectSingleNode("channel/interval").InnerText, out interval);
                
                if(lastSync.AddMilliseconds(interval).CompareTo(DateTime.Now) < 0)
                {
                    GetAddNewPod(podcast, url, category, interval.ToString());
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Interval error.");
            }

            foreach(XmlNode node in podxml.DocumentElement.SelectNodes("item"))
            {
                var title = node.SelectSingleNode("title");
                avsnitt.Items.Add(title.InnerText);
            }
        }

        public void GetEpisodeDescription(string category, string podcast, string avsnitt, RichTextBox epdesc)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + podcast + @".xml";

            XmlDocument descxml = new XmlDocument();
            descxml.Load(path);

            foreach(XmlNode node in descxml.DocumentElement.SelectNodes("item"))
            {
                var title = node.SelectSingleNode("title");
                if (avsnitt.Equals(title.InnerText))
                {
                    var desc = node.SelectSingleNode("description");
                    string desctext = desc.InnerText;
                    string trimmeddesctext = desctext.Replace("<p>", string.Empty).Replace("</p>", string.Empty);
                    epdesc.Text = trimmeddesctext;
                }
            }
        }

        public void GetEpisodeInfo(string category, string podcast, string avsnitt, Label epname, Label epstatus)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + podcast + @".xml";

            XmlDocument epstatusxml = new XmlDocument();
            epstatusxml.Load(path);

            foreach (XmlNode item in epstatusxml.DocumentElement.SelectNodes("item"))
            {
                var title = item.SelectSingleNode("title");
                var status = item.SelectSingleNode("status");
                if (avsnitt.Equals(title.InnerText))
                {
                    epname.Text = title.InnerText;
                    epstatus.Text = status.InnerText;
                }
            }
        }

        public void GetPodcastInfo(string category, string podcast, Label lastsynced, Label podinterval)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + podcast + @".xml";

            XmlDocument podstatusxml = new XmlDocument();
            podstatusxml.Load(path);

            var interval = podstatusxml.SelectSingleNode("channel/interval");
            var lastsync = podstatusxml.SelectSingleNode("channel/lastSync");

            string intervaltext = interval.InnerText;
            bool intervalint = int.TryParse(intervaltext, out int index);
            string converted = "";
            switch (index)
            {
                case 3600000:
                    converted = "One hour.";
                    break;
                case 7200000:
                    converted = "Two hours.";
                    break;
                case 21600000:
                    converted = "Six hours.";
                    break;
                case 43200000:
                    converted = "Twelve hours.";
                    break;
            }
            podinterval.Text = converted;
            lastsynced.Text = lastsync.InnerText;
        }

        public string GetInterval(ComboBox combobox)
        {
            string interval = "";
            int index = combobox.SelectedIndex;

            switch (index)
            {
                case 0:
                    interval = "3600000";
                    break;
                case 1:
                    interval = "7200000";
                    break;
                case 2:
                    interval = "21600000";
                    break;
                case 3:
                    interval = "43200000";
                    break;
            }
            return interval;
        }

        public void GetChangeInterval(string category, string podname, ComboBox combobox)
        {
            changepod.ChangeInterval(category, podname, GetInterval(combobox));
        }

        public void GetDeletePod(string category, string podname)
        {
            delete.Delete(category, podname);
        }
    }
}
