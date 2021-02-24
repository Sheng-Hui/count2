using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace count2
{
    public class Operate
    {

        public decimal num1, num2, result;
        public string operA;

        public void Result()
        {
            Console.WriteLine("計算結果=> " + num1 + " " + operA + " " + num2 + " = " + result);
        }
    }

    //B繼承A
    class Calc : Operate
    {
        public void Addition()
        {
            //Console.WriteLine("Your name1 is :" + name1);
            //Console.WriteLine("Your name2 is :" + name2);
            //Console.WriteLine("Your oper is :" + oper);
            //result = Decimal.Parse(num1) + Decimal.Parse(val2);
            result = num1 + num2;
        }
        public void Subtraction()
        {
            //result = Decimal.Parse(num1) - Decimal.Parse(num2);
            result = num1 - num2;
        }
        public void Multiplication()
        {
            //result = Decimal.Parse(num1) * Decimal.Parse(num2);
            result = num1 * num2;
        }
        public void Division()
        {
            //result = Decimal.Parse(num1) / Decimal.Parse(num2);
            result = num1 / num2;
        }

    }
}
