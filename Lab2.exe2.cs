using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Max_i_min
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream MAX = new FileStream(@"C:\Users\Администратор\Downloads\Naz\N.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream MAX1 = new FileStream(@"C:\Users\Администратор\Downloads\Naz\N.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader lg = new StreamReader(MAX);
            StreamWriter kl = new StreamWriter(MAX1);
            string[] s = lg.ReadLine().Split();
            int max,min;
             max = int.Parse(s[0]);
             min = int.Parse(s[0]);


            for (int i = 0; i < s.Length; i++)
            {
                 int b = int.Parse(s[i]);
                
                 if (max < b)

                 {
                     max = b;
              
                 }
                 if (min > b)
                 {
                     min = b;
                 }


            }
          kl.WriteLine("Max="+max);
          kl.WriteLine("Min="+min);
            
            MAX.Close();
            MAX1.Close();
            lg.Close();
            kl.Close();
            Console.ReadKey();

        }
    }
}
