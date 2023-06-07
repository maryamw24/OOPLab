﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.DL;

namespace UAMS.UI
{
    class Class1UI
    {
        public static Student addStudent()
        {
            List<DegreePrograms> preferences = new List<DegreePrograms>();

            Console.WriteLine("Enter name of the student:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter age of the student:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of the student:");
            double m_marks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of the student:");
            double f_marks = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter name of the student:");
            double e_marks = double.Parse(Console.ReadLine());
            Console.WriteLine("Programs available List");
            for (int i = 0; i < Class3DL.Program_list.Count; i++)
            {
                Console.WriteLine(Class3DL.Program_list[i].Name);
            }
            int p;
            while (true)
            {
                Console.WriteLine("Enter number of preferences u want to add(only 3):");
                p = int.Parse(Console.ReadLine());
                if (p >= 0 && p <= 3)
                {
                    break;
                }
            }
            for (int i = 0; i < p; i++)
            {
                bool flag;
                Console.WriteLine("Enter your " + (i + 1) + " preference:");
                string program = Console.ReadLine();
                for (int j = 0; j < Class3DL.Program_list.Count; j++)
                {
                    if (program == Class3DL.Program_list[j].Name)
                    {
                        preferences.Add(Class3DL.Program_list[j]);
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("Enter the right degree!!");
                        i--;
                        Console.ReadKey();
                    }

                }

            }
            Student s1 = new Student(Name, age, m_marks, f_marks, e_marks, preferences);
            return s1;


        }
        public static void PrintStudents()
        {
            for (int i = 0; i < Class1DL.Sorted_Student.Count; i++)
            {
                if (Class1DL.Sorted_Student[i].reg_degree != null)
                {
                    Console.WriteLine(Class1DL.Sorted_Student[i].Name + " got admission in " + Class1DL.Sorted_Student[i].reg_degree);
                }
                else
                {
                    Console.WriteLine(Class1DL.Sorted_Student[i].Name + " did not get admission");
                }
            }
            Console.ReadKey();
        }
        public static void PrintRegisteredStudents()
        {
            Console.WriteLine("Name".PadRight(20) + "fsc Marks".PadRight(20) + "Ecat Marks".PadRight(20) + "age");
            for (int i = 0; i < Class1DL.Sorted_Student.Count; i++)
            {
                if (Class1DL.Sorted_Student[i].reg_degree != null)
                {
                    Console.WriteLine(Class1DL.Sorted_Student[i].Name.PadRight(20) +Class1DL.Sorted_Student[i].f_marks.ToString().PadRight(20) + Class1DL.Sorted_Student[i].e_marks.ToString().PadRight(20) + Class1DL.Sorted_Student[i].age);
                }
            }
            Console.ReadKey();
        }
        public static void viewStudentsinDegree(string degree)
        {
            Console.WriteLine("Name".PadRight(20) + "fsc Marks".PadRight(20) + "Ecat Marks".PadRight(20) + "age");
            for (int i = 0; i <Class1DL.Sorted_Student.Count; i++)
            {
                if (degree == Class1DL.Sorted_Student[i].Name)
                {
                    Console.WriteLine(Class1DL.Sorted_Student[i].Name.PadRight(20) +Class1DL.Sorted_Student[i].f_marks.ToString().PadRight(20) + Class1DL.Sorted_Student[i].e_marks.ToString().PadRight(20) + Class1DL.Sorted_Student[i].age);
                }
            }
            Console.ReadKey();
        }
        public static void CalculateFee()
        {
            foreach (Student s in Class1DL.Student_List)
            {
                if (s.reg_degree != null)
                {
                    Console.WriteLine(s.Name + "has " + s.CalculateFees() + "fees.");
                }
            }
        }

    }
}
