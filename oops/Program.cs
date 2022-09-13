using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student();


            Teacher t = new Teacher();


            Subject su = new Subject();
            bool output = false;
            do
            {
                Console.WriteLine("Enter any one option shown in Menu below :");
                Console.WriteLine("Menu : \n1)Insert the details \n2)Print the details");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == 1)
                {
                    Console.WriteLine("Enter any one option shown in Menu below :");
                    Console.WriteLine("Menu : \n1)Insert the student details \n2)Insert the Teacherdetails \n3)Insert the Subjectdetails");
                    int insert = Convert.ToInt32(Console.ReadLine());
                    switch (insert)
                    {

                        case 1:
                            s.getstudentsdetails();
                            break;
                        case 2:
                            t.getteacherdetails();
                            break;
                        case 3:
                            su.getsubjectdetails();

                            break;
                        default:
                            Console.WriteLine("Sorry,You have entered the invalid number");
                            break;
                    }
                }


                if (number == 2)
                {
                    Console.WriteLine("Enter any one option shown in Menu below :");
                    Console.WriteLine("Menu : \n1)print the student details \n2)print the Teacherdetails \n3)print the Subjectdetails");
                    int print = Convert.ToInt32(Console.ReadLine());
                    switch (print)
                    {
                        case 1:
                            s.printstudentdetails();
                            Console.WriteLine("-------------------");
                            break;
                        case 2:
                            t.printteacberdetails();
                            Console.WriteLine("-------------------");
                            break;
                        case 3:

                            su.printsubjectdetails();

                            break;
                        default:
                            Console.WriteLine("Sorry,You have not inserted the details for this or you have entered the invalid number");
                            break;
                    }
                }

                Console.WriteLine("Do u want to continue the process or leave the process");
                Console.WriteLine("Menu \n1)Cotinue the process \n2)Leave the process");
                int ex=Convert.ToInt32(Console.ReadLine());
                if (ex == 1)
                {
                    output = false;
                }
                else
                {
                    output= true;
                }
            } while (output != true);



            Console.WriteLine("Thank you process ended");
        }
      

    }
    
}


