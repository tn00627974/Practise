using System;

public class CodeFile
{
    // 撰寫Method 方法(有命名 功能(function)
    // 當作第一支被抽出來執行的主程式(進入點-Entry Point) 
    // public 修飾可見度 (Modifier)可見度
    // static 共用 (這一個方法沒有一個個)
    // void 沒有回應值 (我是起頭程式 不是被呼叫的)
    public static void Main(String[] args) // public 公開、公用的
    {
        //控制台命令列輸出(commmand Line)
        Console.Write("你的名字是 ? ");
        string input = Console.ReadLine();

        Console.Write("你的年紀是 ? ");
        string age = Console.ReadLine();
        Console.WriteLine($"{input}今年{age}歲,哈囉哈囉");
    }
}


