// 常見的資料型態 & 變數
// 變數 string name = "小豬"
// 字串 string "朱帥帥"
// 字元 char 'a'  , char 只能用在單一字上 (需要單引號''做表示)
// 整數 int 40
// 浮點數 double 40.5
// 布林值 bool (true false )




string name = "小豬";


Console.WriteLine("Hello"+name);
System.Console.WriteLine("我我我"+name);

Console.WriteLine(name);

int number = 10;

if (number > 5)
{ Console.WriteLine("Number is greater than 5"); }

else if (number == 5)
{ Console.WriteLine("Number is equal to 5"); }

else
{ Console.WriteLine("Number is less  than 5"); }

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}
