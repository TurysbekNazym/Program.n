using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx3
{
    class Program
    {

        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Git\Clonning");

            int index = 0;
            FileInfo[] files = d.GetFiles();
            bool ok = false;
            while (true)
            {
                if (ok== false)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (index == i)
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.WriteLine(files[i].Name);
                    }
                }
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.UpArrow)
                {
                    if (index > 0)
                        index--;
                }
                if (button.Key == ConsoleKey.DownArrow)
                {
                    if (index < files.Length - 1)
                        index++;
                }
                if (button.Key == ConsoleKey.Enter)
                {
                    FileStream f = new FileStream(files[index].FullName, FileMode.OpenOrCreate, FileAccess.Read);
                    StreamReader sr = new StreamReader(f);
                    Console.Write(sr.ReadToEnd());
                    sr.Close();
                    f.Close();
                    ok = true;

                }
                if (button.Key == ConsoleKey.Escape)
                    ok = false;

                if (ok == false)
                    Console.Clear();
            }
            Console.ReadKey();
        }
    }
}