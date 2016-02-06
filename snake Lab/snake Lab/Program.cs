using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Game game = new Model.Game();
            Console.SetWindowSize(48, 48);
            Console.ReadKey();

        }
    }
}
