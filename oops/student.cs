using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class student
    {

        private string _studentname;

        public string strudentname
        {
            get { return _studentname; }
            set { _studentname = value; }
        }

        private int _classofstudent;

        public int classofstudent
        {
            get { return _classofstudent; }
            set { _classofstudent = value; }

        }

        private string _section;

        public string section
        {
            get
            {
                return _section;
            }
            set
            {
                _section = value;
            }
        }

        List<student> stud=new List<student>();
        public void getstudentsdetails()

        {
            student st = new student();
            Console.WriteLine("Enter the student name :");
            st.strudentname = Console.ReadLine();
            Console.WriteLine("Enter the class of the student");
            st.classofstudent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter section ofthe student");
            st.section = Console.ReadLine();
            stud.Add(st);

        }
        public void printstudentdetails()
        {
            
            foreach(var item in stud)
            {
                Console.WriteLine("Studentname : " + item.strudentname);
                Console.WriteLine("class of student : " + item.classofstudent);
                Console.WriteLine("section : " + item.section);
                Console.WriteLine("  ");
            }
        }
    }
}
