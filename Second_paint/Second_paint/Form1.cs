using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Second_paint
{
    public partial class Form1 : Form
    {
        Drawer drawer;
        private System.Windows.Forms.ColorDialog colorDialog1;
    
        
        
        public Form1()
        {
            InitializeComponent();
            drawer = new Drawer(pictureBox1);
            trackBar1.Minimum = 1;
            trackBar1.SmallChange = 5;
            trackBar1.LargeChange = 8;
            trackBar1.Maximum = 10;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pencil_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.pencil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.rubber;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawer.prev = e.Location;
                drawer.paintStarted = true;
                if (drawer.shape == Shape.fill)
                {
                    drawer.fill(e.Location);
                }
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawer.paintStarted)
            {
                drawer.Draw(e.Location);
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawer.paintStarted = false;
            drawer.saveLastPath();

        }

        private void newPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            drawer.g.Clear(Color.White);
            
            pictureBox1.Refresh();
            drawer.picture.Refresh();
            drawer.path.ClearMarkers();

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            colorDialog1.ShowDialog();
            drawer.pen = new Pen(colorDialog1.Color);
             
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)// if we open this windows it means save
            {
                drawer.SaveImage(saveFileDialog1.FileName);
            }
            

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {


            drawer.pen.Width = trackBar1.Value;
            drawer.rubber.Width = trackBar1.Value;
           
          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.rectangle;


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//
            {
                drawer.OpenImage(openFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.circle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.triangle;

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            drawer.shape = Shape.line;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            drawer.shape = Shape.fill;
        }
         
    }
}

