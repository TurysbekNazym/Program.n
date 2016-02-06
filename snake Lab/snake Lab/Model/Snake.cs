using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_Lab.Model
{
    class Snake:Drawer
    {
        public Snake()
        {
            color = ConsoleColor.DarkGreen;
            sign = '0';


        }
        public void move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)// массив точек жайлап бир биринин артынан козгалады 
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            // так как размер консола 48,48
            if (body[0].x + dx < 0) dx = dx + 48;//сол жактан шыгып кетсе он жактан шыгады
            if (body[0].y + dy < 0) dy = dy + 48;// жогаргы жактагы шекарадын отсе томеннен шыгады
            if (body[0].x + dx > 48) dx = dx - 48;// он жактан шыкса сол жактан келеди
            if (body[0].y + dy > 48) dy = dy - 48;// томеннен шыкса жогарыдан келеди

            body[0].x += dx;
            body[0].y += dy;
            for (int i = 0; i < Game.wall.body.Count - 1; i++)/// проверка столкновения со стеной 
            {
                if (body[0].x == Game.wall.body[i].x && body[0].y == Game.wall.body[i].y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(20, 10);
                    Game.GameOver = true;
                }
            }

            if (body[0].x == Game.food.body[0].x && body[0].y == Game.food.body[0].y)/// басы фудка барса
            {

                Game.foodEaten++;
                if (Game.foodEaten % 8 == 0)
                {
                    Game.wall = new Wall(Game.foodEaten / 8 + 1);//  new level
                    Game.snake = new Snake();
                    Game.food = new Food();
                    Game.food.NewRandomPosition();
                    Game.snake.body.Add(new Point(10, 10));


                }
                Game.food.NewRandomPosition(); 
                body.Add(new Point(0, 0));

            }


        }
    }
}
