using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME_GAME.Model
{
   public  class Food:Drawer
    {
        public Food()
        {
            color = ConsoleColor.Yellow;
            sign = '$';
        }
        public void NewRandomPosition()
        {
            int x = new Random().Next() % 20;
            int y = new Random().Next() % 20;
            bool foodgen = false;
            while (!foodgen)
            {
                 x = new Random().Next(0,20);
                 y = new Random().Next(0,20);
                 foodgen = true;
                 for (int i = 0; i < Game.wall.body.Count; i++)// cheking with wall
                 {
                     if (x == Game.wall.body[i].x && y == Game.wall.body[i].y)// if coordinates of food is equal to the  wall coord do these
                     {
                         foodgen = false;
                         break;
                     }

                 }

                 for (int i = 0; i < Game.snake.body.Count; i++)// cheking with snake position 
                 {
                     if (x == Game.snake.body[i].x && y == Game.snake.body[i].y)//  food VS snake 

                     {
                         foodgen = false;// we could not put here food 
                         break;// loop is over 
                     }
                 }
            }
            if (body.Count == 0)
                body.Add(new Point(x, y));
            else
            {
                body[0].x = x;
                body[0].y = y;
            }
            








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
