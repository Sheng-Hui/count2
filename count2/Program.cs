using System;
using System.Net.Http.Headers;

namespace count2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string時，雖然成功回傳null及數值，中間轉換double四則運算時有誤差，改decimal
            decimal num1, num2;
            var val1 = "";
            var val2 = "";
            var inputVal1 = 1;
            var inputVal2 = 2;

            Console.WriteLine("測試計算機");
            Console.WriteLine("請分別輸入2個數值");
            Console.WriteLine("===============\n");

            val1 = InputVal.GetInt(inputVal1);
            Console.WriteLine("===============\n");
            val2 = InputVal.GetInt(inputVal2);

            //string時，雖然成功回傳null及數值，中間轉換double四則運算時有誤差，改decimal
            num1 = decimal.Parse(val1);
            num2 = decimal.Parse(val2);
            Console.WriteLine("===============\n");
            Console.WriteLine("請輸入運算符號(+,-,*,/): ");
            var oper = Console.ReadLine();
            Console.WriteLine("===============\n");

  
            var result = "";
            var utility = new Utility();
            result = utility.Operate(num1, num2, oper);

            Console.WriteLine("得到的結果為 {0}", result);
        }
    }
}