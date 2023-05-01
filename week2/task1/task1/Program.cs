using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Student.BL;

namespace task1
{

    class Program
    {
        class Student
        {
            public string name;
            public int roll_number;
            public float cGpa;
        }

        static void task1()
        {
            Student s1 = new Student();
            s1.name = "Maryam";
            s1.roll_number = 101;
            s1.cGpa = 3.3F;
            Console.WriteLine("Name:" + s1.name + " roll number:" + s1.roll_number + " CGpa:" + s1.cGpa);
            Console.ReadKey();
        }
        static void task2()
        {
            Student s1 = new Student();
            s1.name = "Maryam";
            s1.roll_number = 101;
            s1.cGpa = 3.3F;
            Student s2 = new Student();
            s2.name = "Ahamd";
            s2.roll_number = 10;
            s2.cGpa = 3.7F;
            Console.WriteLine("Name:" + s1.name + " roll number:" + s1.roll_number + " CGpa:" + s1.cGpa);
            Console.WriteLine("Name:" + s2.name + " roll number:" + s2.roll_number + " CGpa:" + s2.cGpa);
            Console.ReadKey();
        }
        static void task3()
        {
            Student s1 = new Student();
            Console.WriteLine("Enter your name:");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter your roll number:");
            s1.roll_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your cGpa:");
            s1.cGpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Name:" + s1.name + " roll number:" + s1.roll_number + " CGpa:" + s1.cGpa);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int StudentCount = 0;
            Class1[] s = new Class1[10];
            while (true)
            {
                int choice = MainMenu();
                if (choice == 1)
                {
                    s[StudentCount] = AddStudent();
                    StudentCount++;
                }
                if (choice == 2)
                {
                    ViewStudents(s, StudentCount);
                }
                if (choice == 3)
                {
                    topStudent(s, StudentCount);
                }
                Console.ReadKey();
            }
        }
        static int MainMenu()
        {
            int choice;
            Console.WriteLine("1. Add Student");
            Console.WriteLine("1. View Student");
            Console.WriteLine("1. Top Student");
            Console.WriteLine("Enter your choice:");
            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static Class1 AddStudent()
        {
            Class1 s1 = new Class1();
            Console.WriteLine("Enter the name of the Student:");
            s1.Name = Console.ReadLine();
            Console.WriteLine("Enter the roll_number of the student:");
            s1.Roll_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the CGPA of the student:");
            s1.CGPA = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter if the student is hostleite or not (y/n)");
            s1.isHostelite = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter if the student is hostleite or not (y/n)");
            s1.department = Console.ReadLine();
            return s1;
        }
        static void ViewStudents(Class1[] s, int StudentCount)
        {
            for (int i = 0; i < StudentCount; i++)
            {
                Console.WriteLine("Name:" + s[i].Name + "Roll_number:" + s[i].Roll_number + "CGPa:" + s[i].CGPA + "hostellite:" + s[i].isHostelite + "Department:" + s[i].department);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void topStudent(Class1[] s, int StudentCount)
        {
            if (StudentCount == 0)
            {
                Console.WriteLine("No students added!!");

            }
            if (StudentCount == 1)
            {
                ViewStudents(s, 3);
            }
            if (StudentCount == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    int index = Largest(s, i, StudentCount);
                    Class1 temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                ViewStudents(s, 2);
            }
            if (StudentCount == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = Largest(s, i, StudentCount);
                    Class1 temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                ViewStudents(s, 3);
            }
        }

        static int Largest(Class1[] s, int start, int end)
        {
            int index = start;
            float large = s[start].CGPA;
            for (int i = start; i < end; i++)
            {
                if (large < s[i].CGPA)
                {
                    large = s[i].CGPA;
                    index = i;
                }
            }
            return index;
        }
    }
}

