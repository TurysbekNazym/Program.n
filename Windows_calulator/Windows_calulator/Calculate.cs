using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_calulator
{
    class Calculate
    {
        public double first_number ;
        public double second_number ;
        public double  result;
        public string operation;
        public double memory_number;
     public bool operation_press = false;

         public void Esepteu()
        {
            switch (operation)
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
                    result = first_number * second_number / 100;
                    break;
                case "^":

                    result = Math.Pow(first_number, second_number);

                    break;
            }

           
        }
        

    }
}
