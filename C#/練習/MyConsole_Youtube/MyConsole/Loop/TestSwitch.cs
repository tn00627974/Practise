using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole.Loop
{
    internal class TestSwitch
    {
        public static void Main(string[] args)
        {
            // 春季旅遊地票選
            Console.WriteLine("1日月潭/2-花東/3-墾丁/4-宜蘭");
            // 等待輸入
            string select = Console.ReadLine();
            string result = null; 
            switch (select)
            {
                case "1":
                    result = "投 日月潭";
                    break;
                case "2":
                    result = "投 花東";
                    break;
                case "3":
                    result = "投 墾丁";
                    break;
                case "4":
                    result = "投 宜蘭";
                    break;
                default:
                    result = "其他";
                    break; 

            }
            Console.WriteLine(result);

        }
    }
}
