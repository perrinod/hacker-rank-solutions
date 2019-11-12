//https://www.hackerrank.com/challenges/funny-string/problem
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

    static string funnyString(string s) {
        for(int i = 0, j = s.Length - 1; i < s.Length - 1; i++, j--){
            if(Math.Abs(s[i] - s[i+1]) != Math.Abs(s[j] - s[j-1]))
                return "Not Funny";
        }

        return "Funny";

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            string result = funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}