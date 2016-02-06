using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Student
{
    class Student//создаем класс студент
    {   public string name,surname;//  методы 
        public double  gpa;

       public Student (string name,string surname,double gpa)// создаем конструктор
       {
           this.name = name;
           this.surname = surname;
           this.gpa = gpa;
        }

         public override string ToString()// все функиций можно переписать  
         {
              return this.name+""+this.surname+""+this.gpa;
         }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            Student b = new Student();
            b.name = Console.ReadLine();
            b.surname =Console.ReadLine();
            b.gpa = Convert.ToDouble(Console.ReadLine());
            a.name = "Nazym";
            a.surname = "Turysbek";
            a.gpa = 4.0;       // создаем экземпляры от класс студент
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();

 
        }
    }
}
