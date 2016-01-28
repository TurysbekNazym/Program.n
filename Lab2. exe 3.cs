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
           FileStream FF2=new FileStream (@"C:\Users\Администратор\Desktop\Nazym\lab.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
           StreamReader aa= new StreamReader(FF);
           StreamWriter qq=new StreamWriter (FF2);
            int cnt = 0;
            int min = 0;
            bool flag = false;
            string [] s=aa.ReadLine().Split();
            
            foreach (string h in s)
            {
                int number = Convert.ToInt16(h);
                for (int i = 2; i <= number; i++)
                {
                    
                    
                    if (number % i == 0)
                    {
                        cnt++;
                    }
                    if (cnt > 3)
                    {
                        break;

                    }
                    if (cnt==1)
                    {
                        if (!flag)
                        {
                            min = number;
                            flag = true;
                        }
                        if (min > number)
                        
                            min = number;
                     

                    }
                   
                }
                qq.WriteLine(min);
               aa.Close();
                qq.Close();
                FF.Close();
                FF2.Close();

                
            }

        }
    }
}
