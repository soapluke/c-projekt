using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public class AddNewPod
    {
        public static List<string> newPodList = new List<string>();

        public void AddNew(string name, string url, string category = "cool", string interval = "2000")
        {
            Rss rss = new Rss();
            XmlDocument doc = rss.RssReader(url);
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + name + @".xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            int i = 0;

            XmlWriter writeXml = XmlWriter.Create(path, settings);

            writeXml.WriteStartDocument();
            writeXml.WriteStartElement("channel");
            writeXml.WriteElementString("interval", interval);
            writeXml.WriteElementString("url", url);
            writeXml.WriteElementString("lastSync", DateTime.Now.ToString());

            foreach (XmlNode item in doc.DocumentElement.SelectNodes("channel/item"))
            {
                var title = item.SelectSingleNode("title");
                var description = item.SelectSingleNode("description");
                var enclosure = item.SelectSingleNode("enclosure/url");

                writeXml.WriteStartElement("item");

                writeXml.WriteAttributeString("ID", "pod" + i);

                if (description.InnerText.Equals(""))
                {
                    writeXml.WriteElementString("description", "No description available");
                }
                else
                {
                    writeXml.WriteElementString("description", description.InnerText);
                }

                writeXml.WriteElementString("title", title.InnerText);
                writeXml.WriteElementString("enclosure", enclosure.InnerText);
                writeXml.WriteElementString("status", "Unlistened");

                writeXml.WriteEndDocument();
                i++;
            }

            writeXml.WriteEndDocument();
            writeXml.Close();
        }
    }
}
