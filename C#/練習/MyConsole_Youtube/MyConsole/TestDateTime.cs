using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TestDateTime
    {
        public static void Main(string[] args)
        {
            //取出現在時間
            DateTime today = DateTime.Now; // 現在時刻
            DateTime afterday = DateTime.Now.AddDays(46); // 未來時刻
            Console.WriteLine($"今天日期 :{today}到{afterday}");

            //取出國際時間 UTC
            DateTime utc = DateTime.UtcNow ;
            Console.WriteLine($"台灣時間 : {today} 國際時間: {afterday}");

        }
    }
}
