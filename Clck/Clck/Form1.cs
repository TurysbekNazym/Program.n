using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clck
{
    public partial class Form1 : Form
    {
        
        public double first_number;
        public double second_number;
        public double result;
        public string s = "";
        public bool pressed_num = false;
        public double memory_number = 0;

        

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Calck(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

       

        

       

        private void btn_ten_Click(object sender, EventArgs e)
        {
            second_number = double.Parse(textB.Text);
            switch (s)
            {

                case "+":
                    result = first_number + second_number;

                    break;
                case "-":
                    result = first_number - second_number;
                    break;
                case "*":
                    result = first_number * second_number;
                    break;
                case "/":
                    result = first_number / second_number;


                    break;
                case "%":
                    result = (100 * second_number) / first_number;
                    break;

                

                    
            }   
                   textB.Text = result.ToString();
                  // cl.first_number
            
        }

        private void button_click(object sender, EventArgs e)
        {


            if (textB.Text == "0"||pressed_num)
                textB.Clear();
            pressed_num = false;
             Button btn = (Button)sender;
                 textB.Text += btn.Text;
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Operation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            s = btn.Text;
            first_number =double.Parse(textB.Text);
            pressed_num = true;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }

        private void button19_Click(object sender, EventArgs e)
        {
            first_number = 0;
            pressed_num = false;
            second_number = 0;
            s = 0 + "";
            textB.Text = "";

        }

        private void M_operation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            s = btn.Text;
            switch (s)
            {
                case "MS":
                    memory_number = double.Parse(textB.Text);
                    textB.Text = "";
                    break;
                case"MR":
                    textB.Text = memory_number.ToString();
                    break;
                case "MC":
                    memory_number = 0;
                    first_number = 0;
                    second_number = 0;
                    textB.Text = "";
                    break;
                


            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textB.Text);
            if (a < 0)
            {

                a *= (-1);
                textB.Text = a.ToString();
            }
            else if (a > 0)
            {
                a *= (-1);
                textB.Text= a.ToString();
            }
        }

        private void btn_utir(object sender, EventArgs e)
        {
            int cnt = 1;
            if (cnt == 1)
            {
                textB.Text += ",";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textB.Text);
            double b = a * a;
            textB.Text = b.ToString();

            
        }

        
        
        
    }
}
