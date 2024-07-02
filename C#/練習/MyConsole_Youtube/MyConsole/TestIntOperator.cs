using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TestIntOperator
    {
        public static void Main(String[] args)
        {
            // 定義區域變數Local Variable (內容可以變，型別固定的Strong Type強型別)
            Int16 myvalue1 = 10000;
            Int16 myvalue2 = 10000;
            Int16 myvalue;
            myvalue = (Int16)(myvalue1 * myvalue2);
            Console.WriteLine("myvalue 的總值是：" + myvalue);
            Console.WriteLine("---------------------------");


            System.Console.WriteLine("請輸入第一個浮點數");
            double num3 = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("請輸入第二個浮點數");
            double num4 = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine(num3 + num4);
            Console.WriteLine("---------------------------");

            Single s1 = 100.123456789f; // 單精準32bit
            Double d1 = 100.123456789f;
            Console.WriteLine("單精準" + s1);
            Console.WriteLine("倍精準" + d1);
            Console.WriteLine("---------------------------");



        }
    }
}




    

