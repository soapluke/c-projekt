using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public class ChangePodcast
    {
        public void Move(string oldcategory, string newcategory, string podcast)
        {
            string oldpath = Directory.GetCurrentDirectory() + @"\" + oldcategory + @"\" + podcast + @".xml";
            string newpath = Directory.GetCurrentDirectory() + @"\" + newcategory + @"\" + podcast + @".xml";

            try
            {
                File.Move(oldpath, newpath);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ChangeInterval(string category, string podname, string interval)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + podname + @".xml";
            XmlDocument intervalxml = new XmlDocument();
            intervalxml.Load(path);

            var intervalnode = intervalxml.SelectSingleNode("channel/interval");
            intervalnode.InnerText = interval;
            intervalxml.Save(path);
        }
    }
}
