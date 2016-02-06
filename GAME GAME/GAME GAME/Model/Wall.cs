using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace GAME_GAME.Model
{
   public class Wall:Drawer
    {
        public Wall(int level)
        {
            color = ConsoleColor.Red;
            sign = '#';
            Init(level);
        }
        public void Init(int level)
        {
            body.Clear();
            FileStream fs = new FileStream(string.Format(@"C:\Git\Clonning\lev 1{0}.txt", level), FileMode.OpenOrCreate, FileAccess.ReadWrite);// 
            // если съел то небходимое количество еды автоматический открывается следующий уровень


            StreamReader sr = new StreamReader(fs);// 
            

            string[] token = sr.ReadToEnd().Split('\n');
            int row = -1;
            foreach (string s in token)
            {
                row++;
                int col = -1;
                foreach (char ch in s)
                {
                    col++;
                    if (ch == '#')
                        body.Add(new Point(col, row));
                }
            }

        }
    }
}
