using System;
using System.Collections.Generic;
using System.Text;

namespace count2
{
    class InputVal
    {
        public static string Getdecimal(decimal n1)
        {
            //var n2 = "";
            //作為判斷數值是否為整數或分數
            double judgetDouble;
            Console.Write($"請輸入數值{n1}: ");
            var n2 = Console.ReadLine();
            
            if (Double.TryParse(n2, out judgetDouble))
            {
                if ((Double.Parse(n2)) % 1 == 0)
                {
                    Console.WriteLine($"數值{ n1}: { n2} 整數");
                }
                else
                {
                    Console.WriteLine($"數值{ n1}: {n2} 小數");
                }
            }
            else
            {
                //Console.WriteLine($"數值{ n1}: '{n2}'，請輸入整數或小數");
                //return null;
                while (!Double.TryParse(n2, out judgetDouble))
                {
                    Console.WriteLine($"{n2} 格式錯誤，請輸入整數或小數");
                    Console.Write($"\n請輸入數值{n1}: ");
                    n2 = Console.ReadLine();
                }
            }
            return n2;

        }
    }
}
