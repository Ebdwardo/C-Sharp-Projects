using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TempConverter : Form
    {
        public TempConverter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //storing whatever is put into the first text box and converting to an int
            string var = textBox1.Text;
            int a = Int32.Parse(var);

            //converting the celcius value to farenhiet and changing the first label to it
            temp.Service1Client tempService = new temp.Service1Client();
            int temperature = tempService.c2f(a);
            label1.Text = Convert.ToString(temperature);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //storing whatever is put into the second text box and converting to an int
            string var = textBox1.Text;
            int a = Int32.Parse(var);

            //converting the celcius value to farenheit and changing the second label to it
            temp.Service1Client tempService = new temp.Service1Client();
            int temperature = tempService.f2c(a);
            label2.Text = Convert.ToString(temperature);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
