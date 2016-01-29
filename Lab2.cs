using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2_lower_Prime
{
    class Program
    {
       
        static void Main(string[] args)
        {
            FileStream FF = new FileStream(@"C:\Users\Администратор\Desktop\Nazym\lab.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FF2=new FileStream (@"C:\Users\Администратор\Desktop\Nazym\lab2.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamReader aa= new StreamReader(FF);
            StreamWriter qq=new StreamWriter (FF2);
            int cnt = 0;
            int min = 0;
            bool flag = false;
            string [] s=Console.ReadLine().Split();

            foreach (string h in s)
            {
                int number = int.Parse(h);
                cnt = 0;
                for (int i = 2; i <= number; i++)
                {


                    if (number % i == 0)
                    {
                        cnt++;
                    }
                    if (cnt >= 2)
                    {
                        break;

                    }
                }
                if (cnt == 1)
                {
                    if (!flag)
                    {
                        min = number;
                    }
                    if (min > number)

                        min = number;
                }
            }
            Console.WriteLine(min);
            qq.WriteLine(min);
            aa.Close();
            qq.Close();
            FF.Close();
            FF2.Close();
            Console.ReadKey();
        }   
               

                
            

        
     } 
}
