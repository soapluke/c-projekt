using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Validation
    {
        public static bool CheckIfEmpty(TextBox text, string field)
        {

            if (String.IsNullOrWhiteSpace(text.Text))
            {
                MessageBox.Show($"You need to enter a {field} before continuing.", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckIfEmpty(ComboBox box, string field)
        {
            if(box.SelectedIndex == -1)
            {
                MessageBox.Show($"You need to choose {field} from the dropdown menu.", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckIfCorrectUrl(TextBox text)
        {
            try
            {
                var xml = "";
                using (var webclient = new System.Net.WebClient())
                {
                    webclient.Encoding = Encoding.UTF8;
                    xml = webclient.DownloadString(text.Text);
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid URL.", "Error");
                return false;
            }
        }
    }
}
