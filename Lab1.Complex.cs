﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Complex_class
{
    class Complex
    {
       public int a, b;// создаем  комплексные числа 
       public Complex(int a, int b)// создаем   конструктор   который вызывает экземпляры 
       {
           this.a = a;// создаем указатель который ссылается на экземпляры класса    
           this.b = b;

       }
       public static Complex operator +(Complex e1, Complex e2)// создаем оператор+ для суммировки параметров  

       {
           Complex e3 = new Complex(e1.a + e2.a,e1.b + e2.b);
           return e3;
       }
       public override string ToString() // переписываем что нам надо  
       {
           return a + "" + b;
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex n = new Complex(8, 8);// придаем значения параметрам 
            Complex m = new Complex(5, 6);
            Complex v = n + m;
            Console.WriteLine(v);
            Console.ReadKey();

            


        }
    }
}
