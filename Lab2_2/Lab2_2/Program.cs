using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream ww = new FileStream(@"C:\Users\Администратор\Downloads\Naz\infile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);//создаем 
            // файл для прочитать набор чисел
           
            StreamReader ee = new StreamReader(ww);// поток который читываеть набор чисел
          
            string[] Numbers = ee.ReadLine().Split();
         
            int max = int.Parse(Numbers[0]);
            int min = int.Parse(Numbers[0]);
            foreach (string B in Numbers)
            {
                int A = int.Parse(B);
                if (min > A)
                    min = A;
                if (max < A)
                    max = A;
            }
            Console.WriteLine("Max ={0},Min={1}", max , min);
            ee.Close();
            ww.Close();
            Console.ReadKey();
            

        }
    }
}
