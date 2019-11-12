//https://www.hackerrank.com/challenges/string-construction/problem
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

    static int stringConstruction(string s) {
        SortedSet<char> characters = new SortedSet<char>();

        foreach(char c in s)
            characters.Add(c);

        return characters.Count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = stringConstruction(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
