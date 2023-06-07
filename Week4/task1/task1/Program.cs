using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.BL;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>();
            while (true)
            {

                int option = menu();
                if (option == 1)
                {
                    TakeInput(Students);
                }
                if (option == 2)
                {
                    for(int i = 0; i < Students.Count; i++)
                    {
                         Students[i].merit =  Students[i].meritCalculator();
                        Console.WriteLine(Students[i].Name.PadRight(20) + Students[i].merit);

                    }
                    Console.ReadKey();

                       }
                if (option == 3)
                {
                    for (int i = 0; i < Students.Count; i++)
                    {
                        Students[i].isTakingScholarship = Students[i].isEligible();
                        Console.WriteLine(Students[i].Name.PadRight(20) + Students[i].isTakingScholarship);

                    }
                    Console.ReadKey();
                }
            }

        }
        static  int  menu()
        {
            int option;
            Console.WriteLine("1. Add student information");
            Console.WriteLine("2. Calculate and Display merit");
            Console.WriteLine("3. Check the eligibility for scholarship");
            Console.WriteLine("Enter tour option");
            option = int .Parse(Console.ReadLine());
            return option;
        }
        static void TakeInput(List<Student> Students)
        {
            Console.WriteLine("Enter the name of student");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the roll_no of student");
            int roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of student");
            float Cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the matric marks of student");
            int m_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fsc marks of student");
            int f_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ecat marks of student");
            int e_marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the home town of student");
            string homeTown = Console.ReadLine();
            Console.WriteLine("Enter if u are a hostelite (true or false");
            bool isHostelite = bool.Parse(Console.ReadLine());
            Console.ReadKey();
            Student s = new Student(Name, roll_no, Cgpa, m_marks, f_marks, e_marks, homeTown, isHostelite);
            Students.Add(s);

        }
    }
}
