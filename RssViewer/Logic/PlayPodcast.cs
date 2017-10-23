using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Logic
{
    public class PlayPodcast
    {
        public void GetPodUrl(string category, string podcast, string avsnitt, out string url)
        {
            url = "";
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + podcast + @".xml";

            XmlDocument podurl = new XmlDocument();

            podurl.Load(path);

            foreach(XmlNode node in podurl.DocumentElement.SelectNodes("item"))
            {
                var title = node.SelectSingleNode("title");
                var enclosure = node.SelectSingleNode("enclosure");
                var status = node.SelectSingleNode("status");

                if (avsnitt.Equals(title.InnerText))
                {
                    url = enclosure.InnerText;
                    status.InnerText = "Listened to.";
                    podurl.Save(path);
                }
            }
        }
    }
}
