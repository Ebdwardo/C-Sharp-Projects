using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Project_4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string addTeam(string url, string teamName, string college, string Conference, string qb1first, string qb1last, string qb2first, string qb2last, string Number, string Number2, string qbr1, string qbr2,string h1, string h2, string wk1, string wk2, string wk3)
        {

            //create new instance of XmlDocument
            XmlDocument doc = new XmlDocument();

            //load from file
            doc.Load(url);

            //Create the Team element
            XmlElement team = doc.CreateElement("Team");
                       
            //Create all the elements inside Team
            XmlElement name = doc.CreateElement("Name");
            XmlText text = doc.CreateTextNode(teamName);
            name.AppendChild(text);

            XmlElement College = doc.CreateElement("College");
            XmlText collegeName = doc.CreateTextNode(college);
            College.AppendChild(collegeName);

            XmlElement conference = doc.CreateElement("Conference");
            XmlText conferenceName = doc.CreateTextNode(Conference);
            conference.AppendChild(conferenceName);

            XmlElement quaterBack1 = doc.CreateElement("Quarterback");
            quaterBack1.SetAttribute("Height", h1);
            XmlElement qbName = doc.CreateElement("Name");
            XmlElement First = doc.CreateElement("First");
            XmlText firstname = doc.CreateTextNode(qb1first);
            First.AppendChild(firstname);
            XmlElement Last = doc.CreateElement("Last");
            XmlText lastname = doc.CreateTextNode(qb1last);
            Last.AppendChild(lastname);
            qbName.AppendChild(First);
            qbName.AppendChild(Last);

            XmlElement number = doc.CreateElement("Number");
            XmlText number1 = doc.CreateTextNode(Number);
            number.AppendChild(number1);
            XmlElement QBR = doc.CreateElement("QBR");
            XmlText Qbr1 = doc.CreateTextNode(qbr1);
            QBR.AppendChild(Qbr1);


            quaterBack1.AppendChild(qbName);
            quaterBack1.AppendChild(number);
            quaterBack1.AppendChild(QBR);

            XmlElement quaterBack2 = doc.CreateElement("Quarterback");
            quaterBack2.SetAttribute("Height", h2);
            XmlElement qbName2 = doc.CreateElement("Name");
            XmlElement First2 = doc.CreateElement("First");
            XmlText firstname2 = doc.CreateTextNode(qb2first);
            First2.AppendChild(firstname2);
            XmlElement Last2 = doc.CreateElement("Last");
            XmlText lastname2 = doc.CreateTextNode(qb2last);
            Last2.AppendChild(lastname2);

            qbName2.AppendChild(First2);
            qbName2.AppendChild(Last2);

            XmlElement qbnum2 = doc.CreateElement("Number");
            XmlText number2 = doc.CreateTextNode(Number2);
            qbnum2.AppendChild(number2);
            XmlElement QBR2 = doc.CreateElement("QBR");
            XmlText Qbr2 = doc.CreateTextNode(qbr2);
            QBR2.AppendChild(Qbr2);

            quaterBack2.AppendChild(qbName2);
            quaterBack2.AppendChild(qbnum2);
            quaterBack2.AppendChild(QBR2);

            XmlElement schedule = doc.CreateElement("Schedule");
            XmlElement Wk1 = doc.CreateElement("Wk1");
            XmlText weekl = doc.CreateTextNode(wk1);
            Wk1.AppendChild(weekl);
            XmlElement Wk2 = doc.CreateElement("Wk2");
            XmlText week2 = doc.CreateTextNode(wk2);
            Wk2.AppendChild(week2);
            XmlElement Wk3 = doc.CreateElement("Wk3");
            XmlText week3 = doc.CreateTextNode(wk3);
            Wk3.AppendChild(week3);
            schedule.AppendChild(Wk1);
            schedule.AppendChild(Wk2);
            schedule.AppendChild(Wk3);

            //Append all the elements to Team
            team.AppendChild(name);
            team.AppendChild(College);
            team.AppendChild(conference);
            team.AppendChild(quaterBack1);
            team.AppendChild(quaterBack2);
            team.AppendChild(schedule);

            //Append Team to the end of the XML file
            doc.LastChild.AppendChild(team);

            string fLocation = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"App_Data\Teams.xml");
            if (File.Exists(fLocation))
            {
                File.Delete(fLocation);
            }

            //Save the file to the App_Data Folder
            doc.Save(fLocation);

            //return the contents
            return doc.OuterXml.ToString();

        }

        public string verification(string xmlUrl, string xsdUrl)
        {
            //If no errors
            string output = "No Errors";
            string xml;
            var set = new XmlSchemaSet();

            using (var wc = new WebClient())
            {
                try
                {
                    //Downloads the XML document using the URL
                    xml = wc.DownloadString(xmlUrl); 
                }
                catch (WebException e)
                {
                    output = "XML INVALID";
                    return output;
                }
            }

            //Loads xml string into XmlDocument object
            var xd = new XmlDocument(); 
            xd.Load(xmlUrl);
            
            var xdoc = XDocument.Load(new XmlNodeReader(xd));

            //Loads the schema into the schema set
            set.Add(null, xsdUrl);

            //validates the xml document
            xdoc.Validate(set, (o, e) => 
            {
                output = e.Message;
            });

            return output;
        }
    }


}
