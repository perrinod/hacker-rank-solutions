// https://www.hackerrank.com/challenges/strong-password/problem
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

    static int minimumNumber(int n, string password) {
        int count = 0;
        Regex lowerCase = new Regex(".*[a-z].*");
        Regex upperCase = new Regex(".*[A-Z].*");
        Regex digit = new Regex(".*[0-9].*");
        Regex specialCharacter = new Regex("^[a-zA-Z0-9]*$");

        if(!lowerCase.IsMatch(password))
            count++;
        if(!upperCase.IsMatch(password))
            count++;
        if(!digit.IsMatch(password))
            count++;
        if(specialCharacter.IsMatch(password))
            count++;

        return Math.Max(count, 6 - n);
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string password = Console.ReadLine();

        int answer = minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
