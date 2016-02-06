using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_GAME
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 40);
            Model.Game game = new Model.Game();
            Console.ReadKey();
        }
    }
}
