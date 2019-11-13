//https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem
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

    static int minimumAbsoluteDifference(int[] arr) {
        int minDiff = Int32.MaxValue;
        Array.Sort(arr);
    
        for(int i = 0; i < arr.Length - 1; i++){
            int diff = Math.Abs(arr[i] - arr[i+1]);
            if(diff < minDiff)
                minDiff = diff;
        }

        return minDiff;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = minimumAbsoluteDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}