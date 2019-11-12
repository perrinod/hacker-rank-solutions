//https://www.hackerrank.com/challenges/marcs-cakewalk/problem
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

    static long marcsCakewalk(int[] calorie) {
        long count = 0;
        Array.Sort(calorie);
    
        for(int n = 0, i = calorie.Length - 1; i >= 0; i--, n++)
            count += (calorie[i] * (long)Math.Pow(2,n));

        return count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] calorie = Array.ConvertAll(Console.ReadLine().Split(' '), calorieTemp => Convert.ToInt32(calorieTemp))
        ;
        long result = marcsCakewalk(calorie);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
