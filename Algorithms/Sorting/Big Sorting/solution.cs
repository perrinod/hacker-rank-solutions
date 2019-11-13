//https://www.hackerrank.com/challenges/big-sorting/problem
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

    static string[] bigSorting(string[] unsorted) {
        Array.Sort(unsorted, (a, b) => (a.Length == b.Length ? string.CompareOrdinal(a,b) : a.Length - b.Length));
        return unsorted;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string[] unsorted = new string [n];

        for (int i = 0; i < n; i++) {
            string unsortedItem = Console.ReadLine();
            unsorted[i] = unsortedItem;
        }

        string[] result = bigSorting(unsorted);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
