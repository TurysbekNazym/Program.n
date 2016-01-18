using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Kosu
    {
        public long a, b;
        public Kosu(long a,long b)
        {
            this.a=a;
            this.b=b;

        }
        public static Kosu operator +( Kosu c, Kosu d)
        {
            Kosu e=new Kosu( c.a+d.a,c.b+d.b);
            return e;
        }
        public override string ToString()
        {
            return a+""+b;
            
        }
        static void Main(string[] args)
        {
            Kosu u = new Kosu(11111, 30303);
            Kosu h = new Kosu(250247, 47859);
            Kosu j = u + h;
          
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
