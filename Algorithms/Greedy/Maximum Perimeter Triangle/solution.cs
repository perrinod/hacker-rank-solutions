// https://www.hackerrank.com/challenges/maximum-perimeter-triangle/problem
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

    static int[] maximumPerimeterTriangle(int[] sticks) {
        Array.Sort(sticks);

        for(int i = sticks.Length - 1; i > 1; i--){
            if(sticks[i-2] + sticks[i-1] > sticks[i])
                return new int [] {sticks[i-2], sticks[i-1], sticks[i]};
        }

        return new int [] {-1};
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] sticks = Array.ConvertAll(Console.ReadLine().Split(' '), sticksTemp => Convert.ToInt32(sticksTemp))
        ;
        int[] result = maximumPerimeterTriangle(sticks);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
