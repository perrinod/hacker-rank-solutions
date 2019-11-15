//https://www.hackerrank.com/challenges/anagram/problem
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

    static int anagram(string s) {
        if(s.Length % 2 != 0)
            return -1;
    
        string s1 = s.Substring(0, s.Length / 2);
        string s2 = s.Substring(s.Length / 2, s.Length / 2);

        int count = 0;

        foreach(char letter in s1){
            int found = s2.IndexOf(letter);
            if(found != -1)
                s2 = s2.Remove(found,1);
            else
                count++;

        }

        return count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = anagram(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
