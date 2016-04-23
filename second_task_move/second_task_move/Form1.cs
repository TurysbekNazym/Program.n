using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace second_task_move
{
    public partial class Form1 : Form
    {
        SolidBrush br;
        Timer tr;
        float x = 50;
        float y = 50;
        float w = 25;
        float h = 25;
        float dx = 10;
        float dy = 10;
        public Form1()
        {
            br = new SolidBrush(Color.Blue);
            tr = new Timer();
            tr.Tick += new EventHandler(timer1_Tick);
            tr.Start();
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x + w > Width || x+w==Width)
            {
                dx = -10;
                br = new SolidBrush(Color.Black);
                
            }
            else if (x < 0||x==0)
            {
                dx = 10;
                br = new SolidBrush(Color.Brown);

            }
            else if (y + h > Height || y + h == Height)
            {
                dy = -10;
                br = new SolidBrush(Color.Red);
            }
            else if (y < 0 || y == 0)
            {
                dy = 10;
                br = new SolidBrush(Color.Silver);
            }
            x += dx;
            y += dy;
            Refresh();
        }

        private void re_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(br, x, y, w, h);
            
        }
    }
}
