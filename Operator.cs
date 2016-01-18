using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    

namespace Example 
{
    class Complex 
    {
        public int a, b;

        public Complex(int a,int b)
        {
            this.a=a;
            this.b=b;

         }
        public static Complex operator +(Complex c1,Complex c2 )
        {
            Complex c3=new Complex (c1.a+c2.a,c1.b+c2.b);
            return c3;
        }
        
        public override string ToString()
        {
            return a + "/" + b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(4, 5);
            Complex d = new Complex(3, 2);
            Complex h = c - d;
            Complex j = c + d;
            Console.WriteLine(j);
            Console.WriteLine(h);
            Console.ReadKey();
           
        }
    }
  }
    

