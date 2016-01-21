using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example 
{
    class SummerJob
    {
        public string name;
        public int age;
        public string status;
        public string a, b, c;
        public string day;
        
        public bool Flag=true;
        public void JobFinder()
        {
            Console.WriteLine(this.name + " " + this.age+" "+this.status+" "+this.a,b,c);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {   
             SummerJob P= new SummerJob();
             Console.WriteLine("Hello,Please enter you name:");
             P.name = Console.ReadLine();
             Console.WriteLine("Please enter your age");
             P.age = int.Parse (Console.ReadLine());
            
            if (P.age > 16 && P.age < 65)
            {
                Console.WriteLine("WE find one job for you");
                Console.WriteLine("Who you are? :student ,worker  ,pensioner ");
                P.status = Console.ReadLine();

               if (P.Flag){
                   Console.WriteLine(" waiter in cafe");
               }

             //  else
               //    Console.WriteLine("Baby sitter");
            }
     ///       if (P.age > 12 && P.age < 16)
            {
                Console.WriteLine("Sorry , y");
            }

            Console.ReadKey();


        }
    }
}
