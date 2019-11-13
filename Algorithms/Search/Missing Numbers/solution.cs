//https://www.hackerrank.com/challenges/missing-numbers/problem
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

    static int[] missingNumbers(int[] arr, int[] brr) {
        Array.Sort(arr);
        Array.Sort(brr);
        HashSet<int> missing = new HashSet<int>();

        int i = 0, j = 0;
        while(i < brr.Length){
            if(j >= arr.Length || arr[j] != brr[i])
                missing.Add(brr[i]);
            else
                j++;
        
            i++;
        }

        return missing.ToArray();

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int m = Convert.ToInt32(Console.ReadLine());

        int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp))
        ;
        int[] result = missingNumbers(arr, brr);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}