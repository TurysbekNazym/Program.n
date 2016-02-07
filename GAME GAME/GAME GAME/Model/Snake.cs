using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
namespace GAME_GAME.Model
{
   public class Snake:Drawer
    {
       SoundPlayer startSoundPlayer = new SoundPlayer(@"C:\Users\Администратор\Desktop\Новая папка\explosion1.wav");//играет фонфары когда переходит
       // на следующий уровень знак победы 
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
            {// егер жыланын басы стенамен сайкес келсе онда игра оконченно 
                if (body[0].x == Game.wall.body[i].x && body[0].y == Game.wall.body[i].y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(20, 10);
                    Game.GameOver = true;
                }
            }

            if (body[0].x == Game.food.body[0].x && body[0].y == Game.food.body[0].y)/// басы фудка барса  
            {
                Game.food.NewRandomPosition();
                body.Add(new Point(0, 0));
                Game.clfofood++;// счетчик считает сколько фудов съел снейк
                if (Game.clfofood % 6 == 0)
                {
                    startSoundPlayer.Play();
                    Game.wall = new Wall(Game.clfofood / 6 + 1);
                    Game.LevelN++;//  если он съел 6 штуков еды то переходит в следующй уровень 
                    Game.snake = new Snake();// запускется новая змейка 
                    Game.food = new Food();// еда тоже 
                    Game.food.NewRandomPosition();// новая позиция еды 
                    Game.snake.body.Add(new Point(10, 10));//


                }
                

            }


        }
    }
}
