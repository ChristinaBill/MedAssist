using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedAssist.View
{
    class Validator
    {
        private static String states = "|AL|AK|AS|AZ|AR|CA|CO|CT|DE|DC|FM|FL|GA|GU|HI|ID|IL|IN|IA|KS|KY|LA|ME|MH|MD|MA|MI|MN|MS|MO|MT|NE|NV|NH|NJ|NM|NY|NC|ND|MP|OH|OK|OR|PW|PA|PR|RI|SC|SD|TN|TX|UT|VT|VI|VA|WA|WV|WI|WY|";
        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag.ToString() + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
                return true;
            }
            if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", Title);
                    comboBox.Focus();
                    return false;
                }
                return true;
            }
            return true;
        }

        public static bool IsDate(TextBox textBox)
        {
            try
            {
                Convert.ToDateTime(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be in formate mm-dd-yy.", "Incorrect Date");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be an integer value.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks that the Text Box contains a long or int64.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsInt64(TextBox textBox)
        {
            try
            {
                Convert.ToInt64(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be an integer value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be an Decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Checks if the textbox contains a valid state abbreviation.  Not case sensitive.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsState(TextBox textBox)
        {
            try
            {
                if (textBox.Text.Length == 2 && states.IndexOf(textBox.Text.ToUpper()) > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(textBox.Tag.ToString() + " must be a Valid State Abbreviation.", Title);
                    textBox.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return false;
            }
        }
    }
}
