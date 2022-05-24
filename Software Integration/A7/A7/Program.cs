using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace A7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Course> list = new List<Course>();
            List<Instructor> list1 = new List<Instructor>();

            int entriesFound = 0;
            //var a = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).ToString();
            //var b = Directory.GetParent(a);
            //var c = Directory.GetParent(b.ToString());
            //var d = Directory.GetParent(c.ToString()).FullName;
            //string fLocation = Path.Combine(d, @"App_Data\Courses.csv");

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
                    list.Add(s);

                    //Console.WriteLine(line);
                    //Console.WriteLine("");
                    line = textReader.ReadLine();

                    entriesFound++;

                }

            }

            //1.2a
            Console.WriteLine("1.2a");
            IEnumerable<Course> myQuery =
                from z in list
                where z.Code > 300 && z.Subject == "IEE"
                orderby z.Code
                select z;

            foreach (Course item in myQuery)
            {
                Console.WriteLine("Subject = {0}, Code = {1}, Instructor = {2}", item.Subject, item.Code, item.Instructor);
      
            }
            Console.WriteLine("");


            //1.2b
            Console.WriteLine("1.2b");
            var Query2 =
                from z in list
                group z by z.Subject into bySubjects
                select new { Subject = bySubjects.Key, code = bySubjects };
            foreach (var g in Query2)
            {
                Console.WriteLine("Subject = {0}", g.Subject);
                foreach(var n in g.code)
                {
                    Console.WriteLine(g.Subject +": " + n.Code);
                }
            }
            Console.WriteLine("");

            //1.4
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
                    list1.Add(s);

                    //Console.WriteLine(line);
                    //Console.WriteLine("");
                    line = textReader.ReadLine();

                    entriesFound++;

                }

            }

            //1.5
            Console.WriteLine("1.5");
            var query = from course in list
                        join instructor in list1 on course.Instructor equals instructor.name
                        select new { InstructorName = instructor, code = course };
            foreach (var i in query)
            {
                if(i.code.Code < 300 && i.code.Code > 200)
                Console.WriteLine(i.code.Subject + ": "+ "{0} is taught by {1}", i.code.Code, i.InstructorName.name + ", "  +i.InstructorName.email);
            }
            Console.WriteLine("");


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
