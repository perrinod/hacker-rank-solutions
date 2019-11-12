//https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
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

    static string hackerrankInString(string s) {
        string hackerRank = "hackerrank";
        if(s.Length < hackerRank.Length)
            return "NO";

        int i = 0;
        foreach(char c in s){
            if(hackerRank[i] == c)
                i++;
        
            if(i == hackerRank.Length)
                return "YES";
        }

        return "NO";

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            string result = hackerrankInString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}