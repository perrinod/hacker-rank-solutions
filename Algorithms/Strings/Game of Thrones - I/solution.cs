//https://www.hackerrank.com/challenges/game-of-thrones/problem
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

    static string gameOfThrones(string s) {
        s = String.Concat(s.OrderBy(a => a));

        bool palindrome = s.Length % 2 == 0 ? true : false;

        for(int i = 0, j = 0; j < s.Length; j++){
            if(s[i] != s[j]){
                if((j - i) % 2 != 0){
                    if(palindrome)
                        return "NO";
                    palindrome = true;
                }
            
                i = j;
            }
        }

        return "YES";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
