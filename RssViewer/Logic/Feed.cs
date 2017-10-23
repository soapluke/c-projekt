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

        public void GetDeletePod(string category, string podname)
        {
            delete.Delete(category, podname);
        }
    }
}
