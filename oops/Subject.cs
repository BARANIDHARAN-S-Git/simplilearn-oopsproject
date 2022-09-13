using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Subject
    {
        private string _subjectname;
        public string subjectname
        {
            get { return _subjectname; }
            set { _subjectname = value; }
        }
        private int _subjectcode;

        public int subjectcode
        {
            get
            {
                return _subjectcode;
            }
            set
            {
                _subjectcode = value;
            }
        }

        List<Subject> s = new List<Subject>();
        
        public void getsubjectdetails()

        {
            Subject sm = new Subject();
          
            Console.WriteLine("Enter the subjectname");
            sm.subjectname=Console.ReadLine();
            Console.WriteLine("Enter the subjectcode");
            sm.subjectcode = Convert.ToInt32(Console.ReadLine());
            s.Add(sm);
        }
      
        public void printsubjectdetails()
        {
            
            foreach(var item in s)
            {
                Console.WriteLine("Subject Name : "+item.subjectname);
                Console.WriteLine("Subject Code : "+item.subjectcode);
                Console.WriteLine("  ");
            }


        }
    }
}
