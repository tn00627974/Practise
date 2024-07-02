using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MyConsole.Loop
{
    internal class TestWhile
    {public static void Main(string[] args)
        {
            var team_name = new List<string>(); // 空的List
            int first_number = 0;


            Console.WriteLine("請輸入團隊人數");
            int team_size = int.Parse(Console.ReadLine());


            while (first_number <= team_size-1)
            {
                Console.WriteLine("輸入名稱"); 
                string name = Console.ReadLine();
                if (name == "exit")
                {
                    Console.WriteLine("結束");
                    goto end;
                }
                Console.WriteLine($"{first_number} {name} ");
                team_name.Add(name);
                first_number ++;

            }
            end:
            Console.WriteLine($"全部有{first_number}個名稱");
            foreach (var name in team_name)
            {
                Console.WriteLine(name);
            }
        }
    }
}
