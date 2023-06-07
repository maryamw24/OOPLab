using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.BL
{
    class Student
    {
        public string Name;
        public int roll_no;
        public float Cgpa;
        public int m_marks;
        public int f_marks;
        public int e_marks;
        public string homeTown;
        public bool isHostelite;
        public bool isTakingScholarship;
        public float merit;
        public Student(string Name, int roll_no, float Cgpa, int m_marks, int f_marks, int e_marks, string homeTown, bool isHostelite)
        {
            this.Name = Name;
            this.roll_no = roll_no;
            this.Cgpa = Cgpa;
            this.m_marks = m_marks;
            this.f_marks = f_marks;
            this.e_marks = e_marks;
            this.homeTown = homeTown;
            this.isHostelite = isHostelite;
        }
        public float meritCalculator()
        {
             return ((f_marks / 1100 * 0.6f )+ ((e_marks / 400) * 0.4f));

        }
        public bool isEligible()
        {
            if (merit > 80 && isHostelite == true)
            {
                return true;
            }
            return false;
        }


    }
}
