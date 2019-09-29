//https://www.hackerrank.com/challenges/encryption/problem
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

    static string encryption(string s) {
        int size = s.Length;
        string encrypted = "";
        int L = Convert.ToInt32(Math.Sqrt(size));
        int b = (L * L >= size) ? L : L + 1;
    
        for(int i = 0; i < b; i++){
            for(int j = i; j < size;){
                encrypted = encrypted + s[j];
                j = b + j;
            }
            encrypted = encrypted + " ";
        }

        return encrypted;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}