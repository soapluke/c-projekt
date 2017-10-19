using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Data;

namespace Logic
{
    public class Feed
    {
        AddNewPod newPod = new AddNewPod();

        public void GetAddNewPod(string name, string url, string category, string interval = "2000")
        {
            newPod.AddNew(name, url, category, interval);
        }
    }
}
