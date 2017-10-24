using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ChangeInterval(string category, string podcast)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + podcast + @".xml";


        }
    }
}
