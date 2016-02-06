using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_Lab.Model
{
    class Food:Drawer// класс который рисует 
    {
        public Food()
        {
            color = ConsoleColor.Green;
            sign = '$';
        }
        public void NewRandomPosition()
        {       
            int x = new Random().Next() % 20;
            int y = new Random().Next() % 20;
        //while(empty)
            if (body.Count == 0)
                body.Add(new Point(x, y));
            else
            {
                body[0].x = x;
                body[0].y = y;
            }

        }

    }
}
