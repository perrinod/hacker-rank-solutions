// https://www.hackerrank.com/challenges/caesar-cipher-1/problem
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

    static string caesarCipher(string s, int k) {
        StringBuilder encryptedString = new StringBuilder(s);

        for(int i = 0; i < s.Length; i++){
            if(Char.IsLetter(s[i])){
                char a = Char.IsUpper(s[i]) ? 'A' : 'a';
                encryptedString[i] = (char) (a + (s[i] - a + k) % 26);
            }
        }

        return encryptedString.ToString();

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
