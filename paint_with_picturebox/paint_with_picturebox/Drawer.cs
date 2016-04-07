using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace paint_with_picturebox
{
  //  tolwina i color owirgish kosu
    public enum Tool { Pencil,Rectangle,Cirle,lactic}
    class Drawer
    {
         public Pen pen;
         public Pen pen1;
         public Graphics g;
         public Bitmap btm;
         public PictureBox picture;
         public  Tool tool;
         public Point prev;
         public bool started_Paint=false;
         public Drawer(PictureBox p)
         {
            
             this.picture = p;
             btm = new Bitmap(picture.Width, picture.Height);
             g = Graphics.FromImage(btm);
             picture.Image = btm;
             pen = new Pen(Color.Black,2);
            pen1= new Pen(Color.White,15);


         }
         public void Draw(Point cur)
         {
             switch (tool)
             {

                 case Tool.Pencil:
                 g.DrawLine(pen, prev, cur);
                 prev = cur;
                 break;
                 case Tool.Rectangle:
                 break;
                 case Tool.Cirle:
                 break;
                 case Tool.lactic:
                 g.DrawLine(pen1, prev, cur);
                 prev = cur;
                 break;
             }
             picture.Refresh();
         }
   }



}
