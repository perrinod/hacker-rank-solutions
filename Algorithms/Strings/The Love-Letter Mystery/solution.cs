//https://www.hackerrank.com/challenges/the-love-letter-mystery/problem
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

    static int theLoveLetterMystery(string s) {
        int count = 0;

        for(int i = 0, j = s.Length - 1; i < j; j--, i++)
            count += Math.Abs(s[j] - s[i]);

        return count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            int result = theLoveLetterMystery(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
