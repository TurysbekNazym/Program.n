using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Student
    {
        public string name, surename;
        public int age;
        public string ID;
        public double gpa;
        public void printFullName()
        {
            Console.WriteLine(this.name + "" + this.surename);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Student a = new Student();
            a.name = "Nazym";
            a.surename = "Turysbek";
            a.age = 18;
            a.gpa = 4.0;
            a.ID = "15BD02078";
            Student b = new Student();
            b.name = "Nauryz";
            b.surename = "Turysbekova";
            b.age = 20;
            b.gpa = 3.5;
            a.printFullName();
            b.printFullName();
            Console.ReadKey();
        }
    }

}