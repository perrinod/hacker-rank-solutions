//https://www.hackerrank.com/challenges/countingsort2/problem
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

    static int[] countingSort(int[] arr) {

        int[] count = new int[100];
        for(int i = 0; i < arr.Length; i++)
            count[arr[i]]+= 1;

        int sum = 0;
        for(int i = 0; i < count.Length; i++){
            int temp = count[i];
            count[i] = sum;
            sum += temp;
        }

        int[] output = new int[arr.Length];

        for(int i = 0; i < arr.Length; i++){
            output[count[arr[i]]] = arr[i];
            count[arr[i]] += 1;
        }

        return output;


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = countingSort(arr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}