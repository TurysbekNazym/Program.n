﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace work with files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"D:\Документы\nazym\Nazym.docx", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
            Console.ReadLine();
            


        }
    }
}
