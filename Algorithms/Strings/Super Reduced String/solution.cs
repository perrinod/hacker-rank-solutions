//https://www.hackerrank.com/challenges/reduced-string/problem
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

    static string superReducedString(string s) {
        int i = 0;
        while(i < s.Length - 1){
            if(s[i] == s[i+1]){
                s = s.Remove(i, 2);
                if(i != 0)
                    i--;
            }
            else
                i++;
        }

        if(s.Length == 0)
            s = "Empty String";

        return s;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = superReducedString(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}