// https://www.hackerrank.com/challenges/quicksort1/problem
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

    static int[] quickSort(int[] arr) {
        int pivot = arr[0];
        List<int> equal = new List<int>();
        List<int> left = new List<int>();
        List<int> right = new List<int>();

        for(int i = 0; i < arr.Length; i++){
            if(arr[i] < pivot)
                left.Add(arr[i]);
            else if(arr[i] == pivot)
                equal.Add(arr[i]);
            else
                right.Add(arr[i]);
        }

        List<int> combined = new List<int>(left);

        combined.AddRange(equal);
        combined.AddRange(right);

        return combined.ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = quickSort(arr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}