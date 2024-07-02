using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TestDoWhile
    {
        public static void Main(string[] args)
        {
            int maxCounter = 3;
            int counter = 0;
            // do while
            do
            {
                Console.WriteLine($"第{counter}輸入使用者名稱:");
                String username = Console.ReadLine();

                //if (username.Equals("eric")StringComparison.OrdinalIgnoreCase))
                if (username.Equals("eric", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("不合法");
                    counter++; // 放在這裡使得每次迴圈結束後 counter 都會增加

                }
                else 
                {
                    counter++; // 放在這裡使得每次迴圈結束後 counter 都會增加
                }

            } while (counter < maxCounter);
        }
    }
}
