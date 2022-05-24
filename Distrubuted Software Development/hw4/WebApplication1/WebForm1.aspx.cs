using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //create the proxy to call the methods
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();

            string results = proxy.verification(XMLTextBox.Text, XSDTextBox.Text);

            //Show whether the file is valid for the schema
            Results.Text = results;
            proxy.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //create the proxy to call the methods
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
            string url = "https://www.public.asu.edu/~eteodosi/Teams.xml";

            string text;
            using (var client = new WebClient())
            {
                text = client.DownloadString(url);
            }

            //Display the XML file before adding a Team
            XDocument doc1 = XDocument.Parse(text);
            XMLBefore.Text += doc1.ToString();

            //Add a team
            string results = proxy.addTeam(url, teamNameTextBox.Text, collegeTextBox.Text, ConferenceTextBox.Text, 
                qb1FirstNameTextBox.Text, qb1LastNameTextBox.Text, qb2FirstName.Text, qb2LastName.Text, qb1Number.Text, qb2Number.Text, qb1QBR.Text, qb2Qbr.Text, 
                qb1HeightTextBox.Text, qb2Height.Text, week1.Text, week2.Text, week3.Text);

            //Display the Xml file after adding a Team
            XDocument doc = XDocument.Parse(results);
            ResultsTextBox.Text += doc.ToString();
            proxy.Close();
        }
    }
}