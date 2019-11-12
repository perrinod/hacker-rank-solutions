//https://www.hackerrank.com/challenges/camelcase/problem
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

    static int camelcase(string s) {
        int count = 1;

        foreach(char c in s)
            if(Char.IsUpper(c))
                count++;

        return count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = camelcase(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}