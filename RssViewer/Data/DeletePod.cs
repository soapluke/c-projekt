using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DeletePod
    {
        public void Delete(string category, string name)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + name + @".xml";

            File.Delete(path);
        }
    }
}
