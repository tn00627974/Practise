// 取得用戶輸入

// ReadLine()
System.Console.WriteLine("請輸入你的名字");
string name = System.Console.ReadLine();
System.Console.WriteLine("請輸入你的年紀");
string age = System.Console.ReadLine();
System.Console.WriteLine("你的資料是" + name + age);

// 基本計算機 整數 ToInt32
System.Console.WriteLine("請輸入第一個數");
int num1 = System.Convert.ToInt32((System.Console.ReadLine()));
System.Console.WriteLine("請輸入第二個數");
int num2 = System.Convert.ToInt32((System.Console.ReadLine()));
System.Console.WriteLine(num1 + num2);

// 基本計算機 浮點數 double
System.Console.WriteLine("請輸入第一個浮點數");
double num3 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("請輸入第二個浮點數");
double num4 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine(num3 + num4);

