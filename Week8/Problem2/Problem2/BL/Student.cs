using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    class Student : Person
    {
        private string Program;
        private double Fee;
        private int Year;
        public Student() : base()
        {
        }
        public Student(string Program, double Fee, int Year, string Name, string Adress): base(Name, Adress)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }
        public string GetProgram()
        {
            return Program;
        }
        public void SetProgram(string Program)
        {
            this.Program = Program;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int Year)
        {
            this.Year = Year;
        }
        public double GetFee()
        {
            return Fee;
        }
        public void SetFee(double Fee)
        {
            this.Fee = Fee;
        }
        public override string toString()
        {
            return base.toString() + ", Program: " + Program + ", Year: " + Year + ", Fee: " + Fee;
        }
    }
}
