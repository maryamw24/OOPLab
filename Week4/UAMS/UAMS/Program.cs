using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DegreePrograms> Program_list = new List<DegreePrograms>();
            List<Student> Student_List = new List<Student>();
            List<Student> Sorted_Student = new List<Student>();
            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    addStudent(Program_list);
                }
                else if (option == 2)
                {
                    AddDegree(Program_list);
                }
                else if (option == 3)
                {
                    Console.WriteLine("Enter the name of degree to add Subjects");
                    string name = Console.ReadLine();
                    for (int i = 0; i < Program_list.Count; i++)
                    {
                        if (name == Program_list[i].Name)
                        {
                            Subject s = AddSubject();
                            Program_list[i].AddSubject(s);
                        }
                    }
                }
                else if (option == 4)
                {
                    MeritList(Student_List, Sorted_Student);
                    GiveAdmission(Sorted_Student);
                    PrintStudents(Sorted_Student);
                }
                else if(option == 5)
                {
                    Console.WriteLine("Name".PadRight(20) + "fsc Marks".PadRight(20) + "Ecat Marks".PadRight(20) + "age");
                    for(int i = 0; i < Sorted_Student.Count;i++)
                    {
                        if(Sorted_Student[i].reg_degree != null)
                        {
                            Console.WriteLine(Sorted_Student[i].Name.PadRight(20) + Sorted_Student[i].f_marks.ToString().PadRight(20) + Sorted_Student[i].e_marks.ToString().PadRight(20) + Sorted_Student[i].age);
                        }
                    }
                    Console.ReadKey();
                }  
                else if (option == 6)
                {
                    Console.WriteLine("Enter the name of degree:");
                    string degree = Console.ReadLine();
                    viewStudentsinDegree(degree, Sorted_Student);
                }
                else if(option == 7)
                {
                    Console.WriteLine("Enter the name of student:");
                    string name = Console.ReadLine();
                    Student s = Exist(name, Sorted_Student);
                    if (s != null)
                    {
                        s.ViewSubjects();
                        
                    }

                }
            }
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Add subjects to a specific degree");
            Console.WriteLine("4. Generate Merit list");
            Console.WriteLine("5. View Registered Students");
            Console.WriteLine("6. View Students for a specific Program");
            Console.WriteLine("7. Register Subjects Students");
            Console.WriteLine("8. Calculate Feees for all students ");
            return option = int.Parse(Console.ReadLine());
        }
        static void addStudent(List<DegreePrograms> Program_List)
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
            Student s1 = new Student(Name, age, m_marks, f_marks, e_marks);
            Console.WriteLine("Programs available List");
            for(int i = 0;  i < Program_List.Count; i++)
            {
                Console.WriteLine(Program_List[i].Name);
            }
            int p;
            while (true)
            {
                Console.WriteLine("Enter number of preferences u want to add(only 3):");
                p = int.Parse(Console.ReadLine());
                if( p >= 0 && p <= 3)
                {
                    break;
                }
            }
            for(int i = 0; i< p; i++)
            {
                Console.WriteLine("Enter your " +(i+1) + " preference:");
                string program = Console.ReadLine();
                for(int j = 0; j < Program_List.Count; j++)
                {
                    if(program == Program_List[j].Name)
                    {
                        preferences.Add(Program_List[j]);
                    }
                    else
                    {
                        Console.WriteLine("Enter the right degree!!");
                        Console.ReadKey();
                    }
                }
                Student s2 = new Student(preferences);
            }
            
        }
        static void AddDegree(List<DegreePrograms> Program_list)
        {
            Console.WriteLine("Enter title of degree Program:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter durattion of degree Program:");
            float duration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of seats for the degree:");
            int seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Subjects Adding:");
            Console.WriteLine("Enter number of subjects u want to add:");
            int number = int.Parse(Console.ReadLine());
            DegreePrograms d = new DegreePrograms(Name, duration, seats);
            for(int i = 0; i < number; i ++)
            {
                Subject s = AddSubject();
                d.AddSubject(s);
            }
            Program_list.Add(d);

        }
        
        static Subject AddSubject()
        {
            Console.WriteLine("Enter the code of subject:");
            string code = Console.ReadLine();
            Console.WriteLine("Enter the type of subject:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the credit hours of subject:");
            int creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fees of subject:");
            int subjectFees = int.Parse(Console.ReadLine());
            Subject s = new Subject(code, type, creditHours, subjectFees);
            return s;
        }
        static void MeritList(List<Student> Student_List, List<Student> Sorted_Student)
        {
           for(int i = 0; i < Student_List.Count;i++)
            {
                Student_List[i].calculateMerit();
            }
           for(int i = 0; i <Student_List.Count;i++)
            {
                if(Student_List[i].merit > Student_List[i+1].merit)
                {
                    Sorted_Student[i] = Student_List[i];
                }
                else
                {
                    Sorted_Student[i] = Student_List[i + 1];
                }

            }
        }
        static void GiveAdmission(List<Student> Sorted_Student)
        {
            for(int i= 0; i < Sorted_Student.Count;i++)
            {
                if(Sorted_Student[i].merit > 80)
                {
                    for(int j = 0;j < Sorted_Student[i].preferences.Count; j++)
                    {
                        if(Sorted_Student[i].preferences[j].seats != 0)
                        {
                            Sorted_Student[i].reg_degree = Sorted_Student[i].preferences[j];
                            break;
                        }
                       
                    }
                }
            }
            
        }
        static void PrintStudents(List<Student> Sorted_students)
        {
            for(int i = 0; i < Sorted_students.Count;i++)
            {
                if(Sorted_students[i].reg_degree != null)
                {
                    Console.WriteLine(Sorted_students[i].Name + " got admission in " + Sorted_students[i].reg_degree);
                }
                else
                {
                    Console.WriteLine(Sorted_students[i].Name + " did not get admission");
                }
            }
            Console.ReadKey();
        }
        static void viewStudentsinDegree(string degree, List<Student> Sorted_Student)
        {
            Console.WriteLine("Name".PadRight(20) + "fsc Marks".PadRight(20) + "Ecat Marks".PadRight(20) + "age");
            for (int i = 0; i < Sorted_Student.Count; i++)
            {
                if(degree == Sorted_Student[i].Name)
                {
                    Console.WriteLine(Sorted_Student[i].Name.PadRight(20) + Sorted_Student[i].f_marks.ToString().PadRight(20) + Sorted_Student[i].e_marks.ToString().PadRight(20) + Sorted_Student[i].age);
                }
            }
            Console.ReadKey();
        }
        static Student Exist(string name, List<Student> Sorted_Student)
        {
            for(int i = 0; i < Sorted_Student.Count;i++)
            {
                if(name == Sorted_Student[i].Name)
                {
                    return Sorted_Student[i];
                }
            }
            return null;
        }
    }
}
