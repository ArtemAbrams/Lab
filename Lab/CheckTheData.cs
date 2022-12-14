using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class CheckTheData
    {
        public static bool CheckTheNumber(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                if (uint.TryParse(textBox.Text, out uint number))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Wrong value in " + textBox.Name + " value must be a positive integer");
                    textBox.Clear();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Enter the value in " + textBox.Name);
                return false;
            }
        }
        public static bool CheckTheString(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                if (int.TryParse(textBox.Text, out int number))
                {
                    MessageBox.Show("Wrong value in " + textBox.Name + " the value must be text");
                    textBox.Clear();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Enter the value in " + textBox.Name);
                return false;
            }
        }
        public static bool CheckTheStringForSearch(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                if (int.TryParse(textBox.Text, out int number))
                {
                    MessageBox.Show("Wrong value in " + textBox.Name + " the value was not used in the search");
                    textBox.Clear();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool CheckTheNumberForSearch(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                if (uint.TryParse(textBox.Text, out uint number))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Wrong value in " + textBox.Name + " the value was not used in the search");
                    textBox.Clear();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

