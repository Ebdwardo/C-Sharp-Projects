using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numOfAttempts = 0;
        int secretNum = 0;

        private void SecretNumButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            if (Int32.TryParse(lowerLim.Text, out int n) && Int32.TryParse(upperLim.Text, out int s))
                if(Int32.Parse(lowerLim.Text) < Int32.Parse(upperLim.Text))
                    secretNum = proxy.SecretNumber(Int32.Parse(lowerLim.Text), Int32.Parse(upperLim.Text));
            numOfAttempts = 0;
            proxy.Close();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            if(Int32.TryParse(guess.Text, out int n))
            {
                String results = proxy.checkNumber(Int32.Parse(guess.Text), secretNum);
                numOfAttempts++;
                attempts.Text = "Number of attempts: " + numOfAttempts;
                if (results.Equals("correct"))
                {
                    label4.Visible = true;
                    label4.Text = "Correct!";
                    reset();
                }
                else if (results.Equals("too big"))
                {
                    label4.Visible = true;
                    label4.Text = "Too Big!";
                }
                else
                {
                    label4.Visible = true;
                    label4.Text = "too small!";
                }

            }
            
        }

        private void reset()
        {
            numOfAttempts = 0;
            attempts.Text = "Number of attempts: 0";
        }
    }
}
