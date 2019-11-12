//https://www.hackerrank.com/challenges/mars-exploration/problem
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

    static int marsExploration(string s) {
        int count = 0;
        string sos = "SOS";

        for(int i = 0; i < s.Length; i++){
            if(s[i] != sos[i % 3])
                count++;
        }

        return count;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
