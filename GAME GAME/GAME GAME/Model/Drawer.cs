﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace GAME_GAME.Model
{
   public  class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();// x,y 
        public Drawer() { }
        public void Draw()
        {
            Console.ForegroundColor = color;// свет консоли
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);//
                Console.Write(sign);

            }
        }
        public void Save()
        {
            FileStream fs;
            if (sign == '0')
                fs = new FileStream("snake", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            else if (sign == '#')
                fs = new FileStream("wall", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            else
                fs = new FileStream("Food", FileMode.OpenOrCreate, FileAccess.ReadWrite);
          /*  Type t = GetType();
            
            XmlSerializer xs = new XmlSerializer(t);
            xs.Serialize(fs, this);
            fs.Close();*/
            
            Type t = GetType();
            BinaryFormatter formatter = new BinaryFormatter();
            
            formatter.Serialize(fs, this);
            fs.Close();
          

            
            
        }
        public void Resume()

        {
            string fileName = "";
            if (sign == '#')
                fileName = "wall.xml";
            if (sign == '$')
                fileName = "food.xml";
            if (sign == '0')
                fileName = "snake.xml";

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
           /* XmlSerializer xs = new XmlSerializer(GetType());
            fs.Close();*/
            BinaryFormatter we = new BinaryFormatter();
            we.Serialize(fs, this);
            fs.Close();






        }



    }
}
