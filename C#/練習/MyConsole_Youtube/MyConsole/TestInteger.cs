using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TestInteger
    {
        // 主程式
        public static void Main(String[] args)
        {
            //Value Type值型別
            // 固定長度 變數定義 記憶體空間固定 Common Type 使用結構
            // 定義區域變數Local Variable
            Int16 數字16 = 32767; // 負數-32768 到正數32767。
            Int32 數字32 = 2147483647; // 負數-2147483648  到正數2147483647 。 (int預設32) 
            Int64 數字64 = 9223372036854775807; // 負數-9223372036854775808 到正數9223372036854775807


            Byte b1 = (Byte)數字64;  // Int16 轉Byte 是強固型別String Type,轉型要明確轉型語法
            Console.WriteLine(數字64);
        }

    }
}
