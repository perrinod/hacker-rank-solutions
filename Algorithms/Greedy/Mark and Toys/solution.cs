//https://www.hackerrank.com/challenges/mark-and-toys/problem
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static int maximumToys(int[] prices, int k) {
        int count = 0;
        Array.Sort(prices);
    
        foreach(int toy in prices){
            k -= toy;
        
            if(k > 0)
                count++;
            else
                return count;
        }

        return count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}