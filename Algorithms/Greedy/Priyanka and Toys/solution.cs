// https://www.hackerrank.com/challenges/priyanka-and-toys/problem
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

    static int toys(int[] w) {
        Array.Sort(w);

        int containers = 1;
        int minimum = w[0];

        for(int i = 1; i < w.Length; i++){
            if(w[i] > minimum + 4){
                containers++;
                minimum = w[i];
            }
        }

        return containers;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] w = Array.ConvertAll(Console.ReadLine().Split(' '), wTemp => Convert.ToInt32(wTemp))
        ;
        int result = toys(w);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}