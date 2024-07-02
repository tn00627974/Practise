using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TestRefenenceType
    {
        public static void Main(String[] args)
        {
            // 變數宣告 
            Point p1, p2;

            // 物件實體化
            p1 = new Point();
            p2 = new Point();

            p1.x = 100;
            p1.y = 100;
            Console.WriteLine("x: {0}, y: {1}", p1.x, p1.y);
            p2 = p1; // p1 複製"位置"給p2
            p2.y = 200; // 所以 p1.y = 200
            Console.WriteLine("p1x: {0}, p1y: {1}", p1.x, p1.y); // p1x: 100, p1y: 200
            Console.WriteLine("p2x: {0}, p2y: {1}", p2.x, p2.y); // p2x: 100, p2y: 200

        }
    }
}
