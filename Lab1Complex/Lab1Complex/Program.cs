using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Complex
{
    class Complex
    {
        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            int alymy = c1.a * c2.b + c2.a * c1.b;
            int bolimi = c1.b * c2.b;
            int f = enob(alymy, bolimi);
             alymy/=f;
            bolimi/=f;
            return new Complex(alymy,bolimi);
        }
        private static int enob(int x, int y)
        {
            if (y == 0)return x+y;
            return enob(y, x % y);
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
            Complex q = new Complex(7, 9);
            Complex r = new Complex(1, 3);
            Complex t = q + r;
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
