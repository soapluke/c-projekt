using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Validation
    {
        public bool CheckTextboxEmpty(TextBox text)
        {
            string checktext = text.ToString();

            if (string.IsNullOrWhiteSpace(checktext))
            {
                MessageBox.Show("You can't leave any empty text fields.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckIfComboboxSelected(ComboBox box)
        {
            if(box.SelectedIndex == -1)
            {
                MessageBox.Show("You have to choose from the dropdown menu.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
