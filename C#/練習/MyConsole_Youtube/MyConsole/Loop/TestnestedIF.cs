using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TestnestedIF
    {
        //public static void Main(string[] args)
        //{
        //    //標準輸出CLI C>
        //   System.Console.WriteLine("輸入0-100");
        //    string result = Console.ReadLine();
        //    Console.WriteLine(result);

        //}
        public static void Main(string[] args)
        {
            for (Int32 i = 1; i <= 9; i++)
            {
                for (Int32 j = 1; j <= 9; j++)
                {
                    Console.Write($"{i} x {j} = {(i * j)}\t"); // \t 加一個tab行距
                    // 整個結束
                    if (j == 5)
                    {
                        goto end; // 當 j =5 時候就直接跳出迴圈
                    }
                }
                Console.WriteLine("");
            }
            end:
            Console.WriteLine("整個結束");
        }
    }
}
            
