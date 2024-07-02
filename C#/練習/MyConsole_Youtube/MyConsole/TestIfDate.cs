using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TestIfDate
    {
        public static void Main(string[] args)
        {

            Int16 SI = 100;
            Int32 il = 18;
            Int32 result = SI + il;
            Console.WriteLine(result);

            // 提示
            Console.WriteLine("輸入日期"); // 2023/1/1 11:00:00
            //Console.Write("輸入日期");
            // 進行標準輸入
            string day = Console.ReadLine(); 
            DateTime curdate = DateTime.Parse(day);
            Console.WriteLine(curdate); // 印出 2023/1/1 上午 11:00:00

            var year = (curdate.Year)- 1911 ; // 3934 ?

            Console.WriteLine(year);
            if (year == 2023)
            {
                Console.WriteLine("報名年度正確");
            }
            else 
            {
                Console.WriteLine("報名年度不正確");
            }


        }
    }
}
