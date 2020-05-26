// https://www.hackerrank.com/challenges/equality-in-a-array/problem
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

    static int equalizeArray(int[] arr) {
        int largest = 0;
        int[] frequency = new int[101];

        for(int i = 0; i < arr.Length; i++){
            frequency[arr[i]]++;

            if(largest < frequency[arr[i]])
                largest = frequency[arr[i]];
        }

        return arr.Length - largest;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
