// 進階計算機

//System.Console.Write("請輸入數字 ");
//string input = System.Console.ReadLine();
//System.Console.WriteLine(input);


// 猜數字遊戲 1~50 
// 如果玩家 猜測數字小於答案 告知"數字太小" 
// 如果玩家 猜測數字大於答案 告知"數字太大" 
int answer = 40; 
int max_number = 50; 
int min_number = 1 ; 

int player_number = 0 ;
int guess;
int guessed;

while (answer != player_number)
{
    Console.Write("請輸入數字: ");
    guess = System.Convert.ToInt32(Console.ReadLine());
    if (answer == guess)
    {
        Console.WriteLine("恭喜答對");
        break;
    }
    else if (guess > answer)
    {
        Console.WriteLine("數字太大");
        Console.WriteLine($"請猜{min_number}到{guess}的數字");
        max_number = guess;
    }
    else
    {
        Console.WriteLine("數字太小");
        Console.WriteLine($"請猜{guess}到{max_number}的數字");
        min_number = guess;
    }
}


