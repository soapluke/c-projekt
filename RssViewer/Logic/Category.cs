using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Security.AccessControl;

namespace Logic
{
    public class Category
    {
        List<Category> categoryList = new List<Category>();

        public bool NewFolder(string categoryname)
        {
            Directory.CreateDirectory(categoryname);
            return true;
        }

        //public void AddNewCategory(string categoryname)
        //{
        //    string path = Directory.GetCurrentDirectory() + @"\" + categoryname;
        //    XmlWriterSettings settings = new XmlWriterSettings();
        //    settings.Indent = true;
        //    settings.IndentChars = ("    ");

        //    XmlWriter writeXml = XmlWriter.Create(path, settings);

        //    writeXml.WriteStartDocument();
        //    writeXml.WriteStartElement("channel");

        //    writeXml.WriteEndDocument();
        //    writeXml.Close();


        //}

        public void RemoveCategory(string categoryname)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + categoryname;

            Directory.Delete(path);
        }

        public void ChangeCategoryName(string categoryname)
        {

        }
    }
}
