//https://www.hackerrank.com/challenges/cut-the-sticks/problem
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

    static int[] cutTheSticks(int[] arr) {
        Array.Sort(arr);
        List<int> sticks = new List<int>();
        sticks.Add(arr.Length);

        for(int i = 0; i < arr.Length - 1; i++){
            if(arr[i] != arr[i+1])
                sticks.Add(arr.Length - (i + 1));
        }

        return sticks.ToArray();

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = cutTheSticks(arr);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
