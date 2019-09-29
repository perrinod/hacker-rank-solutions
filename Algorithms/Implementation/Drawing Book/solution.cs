//https://www.hackerrank.com/challenges/drawing-book/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int pageCount(int n, int p) {
        if(n == p || p == 1)
            return 0;

        if(n % 2 == 0)
            n = n + 1;

        int back = (n - p) / 2;
        int front = p / 2;
    
        if (front > back)
            return back;

        return front;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}