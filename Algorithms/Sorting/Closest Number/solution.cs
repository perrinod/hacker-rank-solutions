// https://www.hackerrank.com/challenges/closest-numbers/problem
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

    static int[] closestNumbers(int[] arr) {
        Array.Sort(arr);
        List<int> closest = new List<int>();

        int minimum = Int32.MaxValue;

        for(int i = 1; i < arr.Length; i++){
            if(arr[i] - arr[i-1] < minimum)
                closest.Clear();
            
            if(arr[i] - arr[i-1] <= minimum){
                minimum = arr[i] - arr[i-1];
                closest.Add(arr[i-1]);
                closest.Add(arr[i]);
            }
        }

        return closest.ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = closestNumbers(arr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
