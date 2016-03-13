using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace THREAD_Subject
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread tr1 = new Thread(Sum);
            tr1.Name = "Move_do";
       
            Thread tr2=new Thread(LO);
            tr2.Name="fly_lay";
            tr1.Start();
            tr1.Join();
            tr2.Start();
            Console.ReadKey();
        }
        public  static void Sum()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name +" "+i);
            }
        }
        public static  void LO()
        {
            for (int i = 10; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                }

            }
        }
    }
}
