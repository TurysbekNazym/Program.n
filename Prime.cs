using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Prime_number
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string[] Prime = Console.ReadLine().Split();
            foreach (string s in Prime)
            {
                int ans = 0;
                int b = int.Parse(s);
                for (int j = 2; j <= b; j++)
                {
                    if (b % j == 0)
                    {
                        
                        ans++;
                    }

                }
                if (ans == 1)
                {
                    Console.WriteLine(b);

                }
                

            }

           
            
            
        }
        Console.ReadKey();
    }
}
