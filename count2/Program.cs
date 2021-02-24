using System;
using System.Net.Http.Headers;

namespace count2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string時，雖然成功回傳null及數值，中間轉換double四則運算時有誤差，改decimal
            //把 num1, num2給Class Operate判斷
            //decimal num1, num2;
            var val1 = "";
            var val2 = "";
            var inputVal1 = 1;
            var inputVal2 = 2;

            Calc calc = new Calc();

            Console.WriteLine("=====計算機練習=====");
            Console.WriteLine("請分別輸入2個數值");
            Console.WriteLine("===============\n");

            //輸入2數值，並顯示[輸入數值]為整數或分數
            val1 = InputVal.Getdecimal(inputVal1);
            Console.WriteLine("===============\n");
            val2 = InputVal.Getdecimal(inputVal2);
            Console.WriteLine("===============\n");
            
            //string時，雖然成功回傳null及數值，中間轉換double四則運算時有誤差，改decimal
            
            // 將val丟到宣告的類別calc num中
            calc.num1 = decimal.Parse(val1);
            calc.num2 = decimal.Parse(val2);
            
            Console.Write("請輸入運算符號(+, -, *, /): ");

            var oper = Console.ReadLine();
            //Console.WriteLine(oper);
            //判斷是否輸入運算符號
            while ((oper != "+") && (oper != "-") && (oper != "*") && (oper != "/"))
            {

                Console.Write("格式錯誤，請輸入+, -, *, /: ");
                oper = Console.ReadLine();
                //Console.WriteLine(oper);
            }
            //Console.WriteLine("now oper="+ oper);
            Console.WriteLine("===============\n");

            
            calc.operA = oper;
            switch (oper)
            {
                case "+":
                    calc.Addition();
                    calc.View();
                    break;
                case "-":
                    calc.Subtraction();
                    calc.View();
                    break;
                case "*":
                    calc.Multiplication();
                    calc.View();
                    break;
                case "/":
                    calc.Division();
                    calc.View();
                    break;
            }
            /*
            //進行運算
            //var result = "";

            var utility = new Utility();
            result = utility.Operate(num1, num2, oper);

            Console.WriteLine("得到的結果為 {0}", result);
            */
        }
    }
}