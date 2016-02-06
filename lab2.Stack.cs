using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStackexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stackii(@"C:\Git\Program.n");
        }
        static void Stackii(string path)
        {
            Stack<string> dirs = new Stack<string>(20);// создаем стек
            Console.WriteLine(path + "/" + Directory.GetFiles(path).Length);// количество файлов в начальной папке 
            dirs.Push(path);// добавляем путь начальной папки

            while (dirs.Count > 0)// выполняется цикл, пока стэк не станет пустым
            {
                string currentDir = dirs.Pop();// берется путь последней добавленной папки 
                string[] subDirs = Directory.GetDirectories(currentDir);// в массив добавляются пути папок в текущей папке
                foreach (string str in subDirs)
                {
                    Console.WriteLine(str + ": " + Directory.GetFiles(str).Length);// количество файлов в каждой папке
                    
                    dirs.Push(str);//пути папок добавляются в стэк

                }
            }
            Console.ReadKey();

        }
    }
}
