using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        Feed feed = new Feed();
        public List<String> podList = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnaddrss_Click(object sender, EventArgs e)
        {
            await AddPodCastAsync();
        }

        public async Task AddPodCastAsync()
        {
            feed.GetAddNewPod(tbpodname.Text, tbpodurl.Text);
            lbpodeps.Items.Clear();
            await Task.Delay(5000);

        }
    }
}
