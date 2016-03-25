using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Windows_calulator
{
     
    public partial class Form1 : Form
    {
        Calculate cl = new Calculate();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btns_bt(object sender, EventArgs e)
        {
            if (Screen.Text == "0"||cl.operation_press)
               Screen.Clear();
            cl.operation_press = false;
            Button btn = (Button)sender;

            
            Screen.Text += btn.Text;
        }

        private void Operat(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cl.first_number = double.Parse(Screen.Text);
            cl.operation = btn.Text;
            
          cl.operation_press = true;
            Screen.Text= cl.first_number + "" + cl.operation;

        
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
               cl.second_number = double.Parse(Screen.Text);
               cl.Esepteu();
                Screen.Text = cl.result +"";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OP(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            cl.operation = btn.Text;
            switch (cl.operation)
            {
                case "MS":
                    cl.memory_number = double.Parse(Screen.Text);
                    Screen.Text = "";
                    break;
                case "MR":
                    Screen.Text = cl.memory_number.ToString();
                    break;
                case "MC":
                    cl.memory_number = 0;
                    cl.first_number = 0;
                    cl.second_number = 0;
                    Screen.Text = "";
                    break;
            }
        }
        private void OP2(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            cl.operation = btn.Text;
            switch (cl.operation)
            {
                case "c":
                    cl.first_number = 0;
                    cl.operation_press= false;
                    cl.second_number = 0;
                    cl.operation = 0 + "";
                    Screen.Text = "";
                    break;
                case "back":
                    if (Screen.Text.Length == 1)
                        Screen.Text = "0";
                    else
                        Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1);
                    break;
                case "CE":
                    Screen.Text =0+"";
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Screen.Text.Contains(","))
            {
                Screen.Text += ",";
            }
        }

        private void OP3(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            cl.operation = btn.Text;
            double cnt = 1;
            

            switch (cl.operation)
            {
                case "x!":
                    double a = double.Parse(Screen.Text);
                    for (double i = a; i >0; i--)
                    {
                        cnt *= i;
                        
                    }
                    Screen.Text =cnt + "";
                    break;
                case "x^4":
                    double b = double.Parse(Screen.Text);
                    cl.result = b * b * b * b;
                    Screen.Text = cl.result.ToString();
                    break;
                case "x^3":
                    double c = double.Parse(Screen.Text);
                    cl.result = c * c * c;
                    Screen.Text = cl.result.ToString();
                    break;
                case "sqrt":
                    double d = double.Parse(Screen.Text);
                    cl.result = d * d;
                    Screen.Text = cl.result.ToString();
                    break;
               

            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

