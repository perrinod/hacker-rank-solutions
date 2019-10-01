//https://www.hackerrank.com/challenges/sock-merchant/problem
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

    static int sockMerchant(int n, int[] ar) {
    Dictionary<int,int> socks = new Dictionary<int,int>();

        foreach(int number in ar){
            int value;

            if(socks.TryGetValue(number, out value))
                socks[number]++;
            else
                socks.Add(number,1);
        }

        int pairs = 0;
        foreach(KeyValuePair<int,int> number in socks){
            pairs += (number.Value / 2);
        }

        return pairs;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
