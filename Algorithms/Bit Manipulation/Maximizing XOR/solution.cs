// https://www.hackerrank.com/challenges/maximizing-xor/problem
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

    static int maximizingXor(int l, int r) {
        int largest = 0;

        for(int i = l; i <= r; i++)
            for(int j = l; j <= r; j++)
                largest = Math.Max(largest, i^j);

        return largest;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine());

        int r = Convert.ToInt32(Console.ReadLine());

        int result = maximizingXor(l, r);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}