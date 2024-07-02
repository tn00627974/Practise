// 字串常用的用法

string phrase = "Hello Mr.white";

// \n換行符號
System.Console.WriteLine("123\n123");

// IndexOf() 找出索引在第幾位 
System.Console.WriteLine(phrase.IndexOf("white")); // 地9位置

// ToUpper() 轉大寫
System.Console.WriteLine(phrase.ToUpper());

// ToLower() 轉小寫
System.Console.WriteLine(phrase.ToLower());

// Contains() 查詢字串裡面的子字串
System.Console.WriteLine(phrase.Contains("Hello"));

// phrase[1] = 取第二個字串 "e"
System.Console.WriteLine(phrase[1]);

// Substring(6,3) 從第六位開始往後數三個位置
System.Console.WriteLine(phrase.Substring(6, 3));