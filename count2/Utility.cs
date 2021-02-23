using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace count2
{
    public class Utility
    {
        //public double Operate(double num1, double num2, string oper)
        //double / 0時，會造成顯示為無限大
        //public string Operate(double num1, double num2, string oper)
        //string時，雖然成功回傳null及數值，中間轉換double四則運算時有誤差，改decimal
        public string Operate(decimal num1, decimal num2, string oper)
        {
            //var result = 0d;
            var result = "";
            /*
            var addition = new Addition();
            var subtraction = new Subtraction();
            var multiplication = new Multiplication();
            var division = new Division();
            */
            //判斷oper 並分別計算結果
            switch (oper)
            {
                case "+":
                    var addition = new Addition();
                    result = addition.Operate(num1, num2);
                    break;

                case "-":
                    var subtraction = new Subtraction();
                    result = subtraction.Operate(num1, num2);
                    break;
                
                case "*":
                    var multiplication = new Multiplication();
                    result = multiplication.Operate(num1, num2);
                    break;
                
                case "/":
                    var division = new Division();
                    //防呆，如果數值2為0 將null 顯示除數不得為0
                    if (num2 != 0)
                    {
                        result = division.Operate(num1, num2);
                    }
                    else
                        result = "除數不得為0";
                    break;
            }
            return result;
        }

        private class Addition
        {
            //public double Operate(double n1, double n2)
            public string Operate(decimal n1, decimal n2)
            {
                decimal d = n1 + n2;
                return Convert.ToString(d);
                // reutrn n1 + n2;
            }
        }
        private class Subtraction
        {
            //public double Operate(double n1, double n2)
            public string Operate(decimal n1, decimal n2)
            {
                decimal d = n1 - n2;
                return Convert.ToString(d);
                //return n1 - n2;
            }
        }
        private class Multiplication
        {
            //public double Operate(double n1, double n2)
            public string Operate(decimal n1, decimal n2)
            {
                decimal d = n1 * n2;
                return Convert.ToString(d);
                //return n1 * n2;
            }
        }
        private class Division
        {
            //public double Operate(double n1, double n2)
            public string Operate(decimal n1, decimal n2)
            {
                //防呆，如果數值2為0回傳null
                if (n2 != 0)
                {
                    decimal d = (n1 / n2);
                    return Convert.ToString(d);
                }
                else
                    return null;
            }
        }
    }
}

