using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Drawing.Drawing2D;



namespace Second_paint
{
    public enum Shape { pencil,circle,rectangle,rubber,line,triangle,fill};

    class Drawer
    {
        public Graphics g;
        public GraphicsPath path;
        public Bitmap btm;
        public PictureBox picture;
        public Pen pen;
        public Pen rubber;
        public Shape shape;
        public Point prev;
        public bool paintStarted = false;
        Queue<Point> q = new Queue<Point>();
        bool[,] used = new bool[658,314];
        Color color = Color.Red;

        
       

      public Drawer(PictureBox picturebox)
    {
         
         this.picture = picturebox;
         OpenImage("");
         //btm = new Bitmap(picture.Width, picture.Height);
         //g = Graphics.FromImage(btm);
       //  picture.Image = btm;
         pen = new Pen(Color.Black);
         rubber = new Pen(Color.White);
         picture.Paint += Picture_paint;//event of picturebox

          

    }
      public void Picture_paint(object sender, PaintEventArgs e)
      {
          if (path != null)
          {
              e.Graphics.DrawPath(pen, path);//прмежуточный график когда двигаем 
          }

      }
      public void saveLastPath()
      {
          if (path != null)
          {
              g.DrawPath(pen, path);// basic paint where we are paint when jibergene
          }
      }
      public void Draw(Point cur)
      {
          switch (shape)
          {
              case Shape.pencil:
                  g.DrawLine(pen, prev, cur);
                  prev = cur;
                  break;
              case Shape.rubber:
                  g.DrawLine(rubber, prev, cur);
                  prev = cur;
                  break;

              case Shape.circle:
                  path = new GraphicsPath();
                  path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                  break;
              case Shape.rectangle:
                  path = new GraphicsPath();
                 int width = Math.Abs(cur.X - prev.X),height = Math.Abs(cur.Y - prev.Y);
                 
                  /* if (prev.X<cur.X&&prev.Y<cur.Y)
                       path.AddRectangle(new Rectangle(prev.X, prev.Y, width, height));
                 
                  if (prev.X > cur.X && prev.Y > cur.Y)
                       path.AddRectangle(new Rectangle(cur.X,cur.Y,width,height));
                  if (prev.X < cur.X&& cur.Y<prev.Y)
                       path.AddRectangle(new Rectangle(prev.X,cur.Y,width,height));
                   if (prev.X > cur.X&&cur.Y>prev.Y)
                      path.AddRectangle(new Rectangle(cur.X,prev.Y, width,height));*/
                 int fx = prev.X;
                 int fy = prev.Y;
                 if (cur.X < prev.X)
                     fx = cur.X;
                 if (cur.Y < prev.Y)
                     fy = cur.Y;
                 path.AddRectangle(new Rectangle(fx, fy, width, height));
                 break;
                  
              case Shape.line:
                  path = new GraphicsPath();
                  path.AddLine(prev, cur);
                  break;
            
             case Shape.triangle:
          //  Point[] p = { new Point(prev.X, prev.Y), new Point(cur.X, cur.Y), new Point((prev.X + cur.X) / 2,prev.Y) };
                  Point p1 = new Point();
                  Point p2 = new Point();
                  p1.X = prev.X + Math.Abs(cur.X - prev.X);
                  p1.Y = prev.Y + Math.Abs(cur.Y - prev.Y);
                  p2.X = prev.X - Math.Abs(cur.X - prev.X);
                  p2.Y = prev.Y + Math.Abs(cur.Y - prev.Y);
                  Point[] p = { new Point(prev.X, prev.Y), new Point(p1.X, p1.Y), new Point(p2.X, p2.Y) };

                  path = new GraphicsPath();
                  path.AddPolygon(p);

               

               break;

          }
          picture.Refresh();

      }
      public void SaveImage(string filename)
      {
          btm.Save(filename);
      }
      public void OpenImage(string filename)
      {
          btm = filename == "" ? new Bitmap(picture.Width, picture.Height)
              : new Bitmap(filename);

          /*if (filename == "")
          {
              btm = new Bitmap(picture.Width, picture.Height);
          }
          else {
              btm = new Bitmap(filename);
          }*/
          g = Graphics.FromImage(btm);
          picture.Image = btm;
      }
      public void fill(Point cur)
      {
          Color clicked_color = btm.GetPixel(cur.X, cur.Y);
          checkNeighbors(cur.X, cur.Y, clicked_color);
          while (q.Count > 0)
          {
              Point p = q.Dequeue();
              checkNeighbors(p.X + 1, p.Y, clicked_color);
              checkNeighbors(p.X, p.Y + 1, clicked_color);
              checkNeighbors(p.X - 1, p.Y, clicked_color);
              checkNeighbors(p.X, p.Y - 1, clicked_color);
          }
          picture.Refresh();
      }
      public void checkNeighbors(int x, int y, Color clicked_color)
      {
          if (x > 0 && y > 0 && x < picture.Width && y < picture.Height)
          {
              if (used[x, y] == false && btm.GetPixel(x, y) == clicked_color)
              {
                  used[x, y] = true;
                  q.Enqueue(new Point(x, y));
                  btm.SetPixel(x, y,color);
              }
          }
      }
       
        
    
public  object Point { get; set; }}
}
