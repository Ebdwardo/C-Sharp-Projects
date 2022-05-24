using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // getting the text from both text boxes and storing them as ints
            string var = textBox1.Text;
            double var1 = Int32.Parse(var);

            string va = textBox2.Text;
            double var2 = Int32.Parse(va);

            //seeing what operation the user wants to do 
            string maff = comboBox1.SelectedItem.ToString();

            //after we know the operations we make sure it is done and outputted
            if (maff.CompareTo("+") == 0)
            {
                label1.Text = Convert.ToString(var1 + var2);
            }
            else if (maff.CompareTo("-") == 0)
            {
                label1.Text = Convert.ToString(var1 - var2);
            }
            else if (maff.CompareTo("*") == 0)
            {
                label1.Text = Convert.ToString(var1 * var2);
            }
            else
            {
                label1.Text = Convert.ToString(var1 / var2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Navigates
            webBrowser1.Navigate(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //refreshes the browser
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //goes to tthe home page
            webBrowser1.GoHome();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //goes back a page in the browser
            webBrowser1.GoBack();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //goes forward a page in the browser
            webBrowser1.GoForward();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            asu.ServiceClient a = new asu.ServiceClient();

            //we encrypt whatever is in the text box 
            string var = textBox4.Text;
            textBox5.Text = a.Encrypt(var);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            asu.ServiceClient a = new asu.ServiceClient();

            //we decrypt whatever is in the text box 
            string var = textBox4.Text;
            textBox5.Text = a.Decrypt(var);
        }
    }
}
