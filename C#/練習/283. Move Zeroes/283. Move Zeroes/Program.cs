using System;
using System.Collections.Generic; // List<T>, Dictionary<TKey, TValue>, HashSet<T>

//public class Solution
//{
//    public IList<IList<int>> Generate(int numRows) {
//        var res = new List<IList<int>>();

//        for (int i = 0; i < numRows; i++) {
//            var now = new List<int>(new int[i + 1]);
//            Console.WriteLine(now);
//        }
//    }

int numRows = 5;

for (int i = 0; i < numRows; i++) {
    var now = new List<int>(new int[i + 1]);

    now[0] = now[i] = 1;
    Console.WriteLine(string.Join(" ",now));


    //foreach (int num in List)
    ////Console.WriteLine(string now));
}