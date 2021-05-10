using System;

namespace Consoleprg1
{
    class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            student1.setstudent_id(219899);
            Console.WriteLine(student1.getstudent_id());

            student1.setstudent_name("kavindu");
            Console.WriteLine(student1.getstudent_name());
              
        }

        class student
        {

            private  int student_id;
            private string student_name;

            public void setstudent_id(int id) 
            {
                student_id = id;

            }

            public int getstudent_id()
            {
                return student_id;

            
            }

            public void setstudent_name(string Name)
            {

                student_name = Name;
            }

            public string getstudent_name()
            {

                return student_name;
            }

        }

    }
}
