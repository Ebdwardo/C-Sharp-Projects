using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace A8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            List<Instructor> instructors = new List<Instructor>();

            int entriesFound = 0;

            using (var textReader = new System.IO.StreamReader(@"./../../../Courses.csv"))
            { //using System.IO
                char _Delimiter = ','; // .csv comma separate values
                string line = textReader.ReadLine();
                int skipCount = 0;
                while (line != null && skipCount < 1)
                { // skip file header
                    line = textReader.ReadLine();
                    skipCount++;
                }
                while (line != null)
                {
                    string[] columns = line.Split(_Delimiter);
                    string[] courseandNum = columns[0].Split(' ');
                    Course s = new Course(courseandNum[0], Int32.Parse(courseandNum[1]), Int32.Parse(columns[2]), columns[1], columns[7], columns[3]);
                    courses.Add(s);

                    //Console.WriteLine(line);
                    //Console.WriteLine("");
                    line = textReader.ReadLine();

                    entriesFound++;

                }

            }

            using (var textReader = new System.IO.StreamReader(@"./../../../Instructors.csv"))
            { //using System.IO
                char _Delimiter = ','; // .csv comma separate values
                string line = textReader.ReadLine();
                int skipCount = 0;
                while (line != null && skipCount < 1)
                { // skip file header
                    line = textReader.ReadLine();
                    skipCount++;
                }
                while (line != null)
                {
                    string[] columns = line.Split(_Delimiter);
                    Instructor s = new Instructor(columns[0], columns[1], columns[2]);
                    instructors.Add(s);

                    //Console.WriteLine(line);
                    //Console.WriteLine("");
                    line = textReader.ReadLine();

                    entriesFound++;

                }

            }

            //2.1
            XDocument myQuery = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Courses",
                from z in courses
                select new XElement("Course", new XAttribute("Subject", z.Subject), new XAttribute("Code", z.Code),
                new XElement("Name", z.Title),
                new XElement("CourseID", z.courseId),
                new XElement("Instructor", z.Instructor),
                new XElement("Location", z.Location)
                )));

            //2.2
            myQuery.Save(@"./../../../App_Data/Courses.xml");

            //2.3a
            Console.WriteLine("2.3a");
            XElement myCourses = XElement.Load(@"./../../../App_Data/Courses.xml");
            IEnumerable<XElement> course =
                from c in myCourses.Elements("Course")
                where (int)c.Attribute("Code") > 200 && (string)c.Attribute("Subject") == "CPI"
                select c;
            foreach (XElement c in course) Console.WriteLine(c);
            Console.WriteLine("");

            //2.3b
            Console.WriteLine("2.3b");
            var Query2 =
               from c in courses
               group c by c.Subject into bySubjects
               from byCode in (
                        from course in bySubjects
                        group course by course.Code)
               where byCode.Count() >= 2
               select new { Subject = bySubjects.Key, Code = byCode };
            foreach (var g in Query2)
            {
                Console.WriteLine("Subject = {0}", g.Subject);
                foreach (var n in g.Code)
                {
                    Console.WriteLine(g.Subject + ": " + n.Code);
                }
            }
            Console.WriteLine("");

            //2.4
            XDocument myQuery1 = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("Instructors",
                from z in instructors
                select new XElement("Instructor",
                new XElement("Name", z.name),
                new XElement("Email", z.email),
                new XElement("Office", z.office)
                )));

            myQuery1.Save(@"./../../../App_Data/Instructors.xml");
            XElement myInstructors = XElement.Load(@"./../../../App_Data/Instructors.xml");

            Console.WriteLine("2.4");
            //XElement query = new XElement("Courses",
            //    from c in myCourses.Elements("Course")
            //    join instructor in myInstructors.Elements("Instructor") on (string)c.Element("Instructor") equals (string)instructor.Element("Name")
            //    where (int)c.Attribute("Code") > 200 && (int)c.Attribute("Code") < 299
            //    select new XElement("Course", new XAttribute("Subject", (string)c.Attribute("Subject")), new XAttribute("Code", (string)c.Attribute("Code")),
            //    new XElement("Name", (string)c.Element("Name")),
            //    new XElement("CourseID", (string)c.Element("CourseID")),
            //    new XElement("Instructor", new XAttribute("Email", (string)instructor.Element("Email")), (string)instructor.Element("Name")),
            //    new XElement("Location", c.Element("Location"))
            //    ));
            //Console.WriteLine(query);
            //Console.WriteLine("");

            IEnumerable<XElement> query =
                from c in myCourses.Elements("Course")
                where (int)c.Attribute("Code") is >= 200 and < 300
                from instructor in instructors
                where c.Element("Instructor").Value.Equals(instructor.name)
                select new XElement("Course", new XAttribute("Subject", (string)c.Attribute("Subject")), new XAttribute("Code", (string)c.Attribute("Code")),
                new XElement("Name", (string)c.Element("Name")),
                new XElement("CourseID", (string)c.Element("CourseID")),
                new XElement("Instructor", new XAttribute("Email", (string)instructor.email), (string)instructor.name),
                new XElement("Location", (string)c.Element("Location"))
                );

            foreach (var i in query) Console.WriteLine(i.ToString());
            Console.WriteLine("");






        }
    }
    class Course
    {
        public String Subject { get; set; }
        public Int32 Code { get; set; }
        public Int32 courseId { get; set; }
        public String Title { get; set; }
        public String Location { get; set; }

        public String Instructor { get; set; }
        public Course(String s, Int32 c, Int32 i, String t, String l, String ins)
        {
            Subject = s;
            Code = c;
            courseId = i;
            Title = t;
            Location = l;
            Instructor = ins;
        }
        public Course()
        {

        }
    }
    class Instructor
    {
        public String name { get; set; }
        public String office { get; set; }
        public String email { get; set; }

        public Instructor(String s, String l, String ins)
        {
            name = s;
            office = l;
            email = ins;
        }
        public Instructor()
        {

        }
    }
}
