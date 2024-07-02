using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TestValueTypeAssign
    {
        public static void Main(String[] args)
        {
            Int32 m1 = 1234;
            Int32 m2 = m1;
            Console.WriteLine(m1);
            m1 = 4321;
            Console.WriteLine(m1);
        }
    }
}
