using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Teacher
    {
        private string _teachername;
        public string teachername
        {
            get { return _teachername; }
            set { _teachername = value; }
        }

        private int _classofteacher;

        public int classofteacher
        {
            get { return _classofteacher; }
            set { _classofteacher = value; }

        }

        private string _sectionofteacher;

        public string sectionofteacher
        {
            get
            {
                return _sectionofteacher;
            }
            set
            {
                _sectionofteacher = value;
            }
        }
        private string _subjectofteacher;

        public string subjectofteacher
        {
            get
            {
                return _subjectofteacher;
            }
            set
            {
                _subjectofteacher = value;
            }
        }
        List<Teacher> t = new List<Teacher>();
     
        
        public void getteacherdetails()

        {
            Teacher tm = new Teacher();

            Console.WriteLine("Enter the Teacher name :");
            tm.teachername = Console.ReadLine();

            Console.WriteLine("Enter the class of the Teacher");
            tm.classofteacher = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter section ofthe Teacher");
            tm.sectionofteacher = Console.ReadLine();
            Console.WriteLine("Enter subject ofthe Teacher");
            tm.subjectofteacher = Console.ReadLine();
            t.Add(tm);




        }
        public void printteacberdetails()
        {
            
            foreach(var item in t)
            {
                Console.WriteLine("Teachername : " + item.teachername);
                Console.WriteLine("class of Teacher : " + item.classofteacher);
                Console.WriteLine("section : " + item.sectionofteacher);
                Console.WriteLine("Subject : " + item.subjectofteacher);
                Console.WriteLine("  ");
            }
        }
    }
}
