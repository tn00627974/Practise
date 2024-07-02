// Array 陣列

string[] phones = new string[3];

phones[0] = "0952739894" ;
phones[1] = "0919074558" ;
phones[2] = "0935756982";

foreach (var num in phones) {
    System.Console.WriteLine(num);
}



int j = 0;
do
{
    Console.WriteLine(j);
    j++;
} while (j < 10);

int j = 0;
while (j < 10)
{
    Console.WriteLine(j);
    j++;
}

static void MyMethod(string fname)
{
    Console.WriteLine(fname + " Refsnes");
}

static void Main(string[] args)
{
    MyMethod("Liam");
}


public partial class Program
{
    static void Main(string[] args)
    {
        // 使用 for 迴圈遍歷1到10的所有數字，包括10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        int score1 = 50;
        int score2 = 60;
        int score3 = 70;
        int[] scores = { 50, 60, 70 };

        foreach (int score in scores)
            System.Console.WriteLine(score);
    }
}



//使用 for 迴圈計算並輸出1到10之間的所有偶數。
//提示：
//使用 for 迴圈遍歷1到10的所有數字。
//使用條件語句來判斷每個數字是否為偶數。
//使用 Console.WriteLine 方法將每個偶數輸出到控制台。
//完成後，你可以在這裡分享你的程式碼，我可以幫你檢查並提供反饋。祝你順利！

//int duo = 0

//for (int i = 0; i <= 10; i++)
//{
//    if (i % 2 == 0) 
//    {
//        duo++;
//    }
//};
//Console.WriteLine("偶數" + duo + "個");
//System.Console.WriteLine($"偶數有{duo}個");

