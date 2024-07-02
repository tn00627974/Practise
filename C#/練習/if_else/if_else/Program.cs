// if 判斷

// 
// 1.如果肚子餓 , 我就去吃飯

using System.Runtime.InteropServices;

bool humgry  = true ;
if (humgry)
{
    Console.WriteLine("吃飯");
}

// 2.
// if 今天有下雨，我就開車去上班
// else 我就走路去上班

string runing = "沒下雨";
if (runing == "下雨")
{
    Console.WriteLine("開車上班去");
}
else 
{
    Console.WriteLine("走路上班去");
}

// 3.
/* 如果   考試=100分，得到1000元
 * 或如果 考試>=80分，得到500元
 * 獲如果 考試>=60分，得到100元
 * 否則   你要給我300元
 */
int score3 = 59 ;
if (score3 >= 100)
{
    Console.WriteLine("得到1000元");
}
else if (score3 >= 80)
{
    Console.WriteLine("得到500元");
}
else if (score3 >= 60)
{
    Console.WriteLine("得到100元");
}
else {
    Console.WriteLine("你要給我300元");
}


// 4.
/* 如果   考試=100分 and 今天有下雨 得到1000元
 * 否則   你要給我100元
 */

int score4 = 100 ;
string rain4 = "null";

if (score4 >= 100 && rain4 == "下雨")
{
    Console.WriteLine("得到1000元");
}
else
{
    Console.WriteLine("你要給我100元");
}

// 5.
/* 如果   考試=100分 or 今天有下雨 得到1000元
 * 否則   你要給我100元
 */

int score5 = 100 ;
string rain5 = "null" ;

if (score5 >= 100 || rain5 == "下雨")
{
    Console.WriteLine("得到1000元");
}
else
{
    Console.WriteLine("你要給我100元");
}

