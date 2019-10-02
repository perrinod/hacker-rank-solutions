//https://www.hackerrank.com/challenges/day-of-the-programmer/problem
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

    static string dayOfProgrammer(int year) {
        string s;
        if(year == 1918)
        return "26.09." + year.ToString();

        if(year < 1918){
            s = year % 4 == 0 ? "12.09." : "13.09.";
        }
        else{
            s = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) ? "12.09." : "13.09.";

        }

        return s + year.ToString();

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
