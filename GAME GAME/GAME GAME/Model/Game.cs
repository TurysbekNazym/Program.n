using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace GAME_GAME.Model
{
    class Game
    {

        public static bool GameOver = false;
        public static Food food = new Food();
        public static Snake snake = new Snake();
        public static Wall wall = new Wall(1);
        public static int clfofood = 0;
        SoundPlayer startSoundPlayer = new SoundPlayer(@"C:\Users\Администратор\Desktop\Новая папка\Звукккк.wav");//стенамен согыскандагы звук

        public Game()
        {
            Init();
            Play();
        }

        public void Play()
        {
            while (!GameOver)
            {
                Draw();
                ConsoleKeyInfo button = Console.ReadKey();// кнопка туралы информация сактайды 
                if (button.Key == ConsoleKey.UpArrow)
                    snake.move(0, -1);
                if (button.Key == ConsoleKey.DownArrow)
                    snake.move(0, 1);
                if (button.Key == ConsoleKey.LeftArrow)
                    snake.move(-1, 0);
                if (button.Key == ConsoleKey.RightArrow)
                    snake.move(1, 0);

                if (button.Key == ConsoleKey.F3)
                    wall.Init(2);

                if (button.Key == ConsoleKey.F2)
                    Save();
                if (button.Key == ConsoleKey.F1)
                    Resume();
            }
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            startSoundPlayer.Play();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over");
            Console.ReadKey();


        }
        public void Save()
        {
            snake.Save();
            wall.Save();
            food.Save();
        }
        public void Init()
        {
            food.NewRandomPosition();
            snake.body.Add(new Point(10, 10));
        }
        public void Resume()
        {
            snake.Resume();
            food.Resume();
            wall.Resume();
        }
        public void Draw()
        {
            Console.Clear();//// консолда барин оширед
            food.Draw();
            snake.Draw();
            wall.Draw();
        }
    }
}
