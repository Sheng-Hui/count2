using System;
using System.Collections.Generic;
using System.Text;

namespace count2
{
    public class Utility
    {
        public double Operate(double num1, double num2, string oper)
        {
            var result = 0d;

            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                       
                    }
                    break;
            }

            return result;
        }
    }
}
