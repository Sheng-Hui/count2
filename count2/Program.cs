using System;
using System.Net.Http.Headers;

namespace count2
{
    class Program
    {
        static void Main(string[] args)
        {
            string val1, val2;
            double judgetDouble, num1, num2;
            Console.WriteLine("測試計算機");
            Console.WriteLine("請分別輸入2個數值");

            Console.WriteLine("===============");
            Console.Write("請輸入數值1，需為整數或小數: ");
            val1 = Console.ReadLine();

            if (Double.TryParse(val1, out judgetDouble))
            {
                //Console.WriteLine(Judget_double);
                if ((Double.Parse(val1)) % 1 == 0)
                {
                    Console.WriteLine("數值1: {0} 整數", val1);
                }
                else
                {
                    Console.WriteLine("數值1: {0} 小數", val1);
                }

            }
            else
            {
                Console.WriteLine($"數值1:'{val1}'，無法轉換為整數或小數");
                return;
            }
            Console.Write("請輸入數值2，需為整數或小數: ");
            val2 = Console.ReadLine();
            if (Double.TryParse(val2, out judgetDouble))
            {
                if ((Double.Parse(val2)) % 1 == 0)
                {
                    Console.WriteLine("數值2: {0} 整數", val2);
                }
                else
                {
                    Console.WriteLine("數值2: {0} 小數", val2);
                }
            }
            else
            {
                Console.WriteLine($"數值2:'{val2}'，無法轉換為整數或小數");
                return;
            }

            num1 = double.Parse(val1);
            num2 = double.Parse(val2);

            Console.WriteLine("請輸入運算符號(+,-,*,/): ");
            var oper = Console.ReadLine();

            //var result = 0d;
            var result = "";
            var utility = new Utility();
            result = utility.Operate(num1, num2, oper);

            Console.WriteLine("得到的結果為 {0}", result);

            //Console.WriteLine("1. + , 2. - , 3. * , 4. /");
            //Console.WriteLine("");
            //Console.WriteLine("===============");

            //Console.WriteLine("1. + ");
            //Console.WriteLine("2. - ");
            //Console.WriteLine("3. * ");
            //Console.WriteLine("4. / ");

            //Console.Write("請輸入1~4 執行四則運算: ");


            //string option = Console.ReadLine();

            //Console.WriteLine("===============");
            //if (option == "1")

            //{
            //    output = num1 + num2;
            //    Console.WriteLine("{0} + {1} = {2}", num1, num2, output);
            //}
            //else if (option == "2")
            //{
            //    output = num1 - num2;
            //    Console.WriteLine("{0} - {1} = {2}", num1, num2, output);
            //}
            //else if (option == "3")
            //{
            //    output = num1 * num2;
            //    Console.WriteLine("{0} * {1} = {2}", num1, num2, output);
            //}
            //else if (option == "4")
            //{
            //    if (num2 != 0)
            //    {
            //        output = num1 / num2;
            //        Console.WriteLine("{0} * {1} = {2}", num1, num2, output);
            //    }
            //    else
            //        Console.WriteLine("數值2 不應該為0", num2);
            //}
            //else
            //    Console.WriteLine("請輸入1~4執行");
            //Console.ReadLine();
            /*
            switch (option)
            {
                case "1":
                    output = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, output);
                    break;
                case "2":
                    output = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, output);
                    break;
                case "3":
                    output = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, output);
                    break;
                case "4":
                    //在case4中加入if失敗
                    //if (num2 != 0)
                    //{
                        output = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, output);
                        break;
                    //}
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.Read();
            /*
            /*
            double Num1, Num2,output;
            
            Console.Write("Input Int Num1: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.Write("Input Int Num2: ");
            Num2 = double.Parse(Console.ReadLine());
            if ((Num1%1==0) && (Num2%1==0))
            {
                Console.WriteLine("=====================");
                Console.WriteLine("Int");
            }
            else
            {
                Console.WriteLine("double");
            }
            Console.WriteLine("=====================");
            Console.WriteLine("1. + :");
            Console.WriteLine("2. - :");
            Console.WriteLine("3. * :");
            Console.WriteLine("4. / :");
            Console.Write("請輸入1~4 執行: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    output = Num1 + Num2;
                    Console.WriteLine("{0} + {1} : {2}", Num1, Num2, output);
                    break;
                case "2":
                    output = Num1 - Num2;
                    Console.WriteLine("{0} - {1} : {2}", Num1, Num2, output);
                    break;
                case "3":
                    output = Num1 * Num2;
                    Console.WriteLine("{0} * {1} : {2}", Num1, Num2, output);
                    break;
                case "4":
                    output = Num1 / Num2;
                    Console.WriteLine("{0} / {1} : {2}", Num1, Num2, output);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.Read();
            */
        }
    }
}