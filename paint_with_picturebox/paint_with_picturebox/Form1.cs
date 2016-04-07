using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_with_picturebox
{
    public partial class Form1 : Form
    {
        Drawer drawer;
        public Form1()
        {
            InitializeComponent();
            drawer = new Drawer(pictureBox1);

            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawer.prev = e.Location;
            drawer.started_Paint = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawer.started_Paint)
            {
                drawer.Draw(e.Location);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawer.started_Paint = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawer.tool = Tool.Pencil;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drawer.tool = Tool.lactic;
        }
    }
}
