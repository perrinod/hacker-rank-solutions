// https://www.hackerrank.com/challenges/extra-long-factorials/problem
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static void extraLongFactorials(int n) {
        BigInteger factorial = 1;

        for(int i = n; i > 1; i--)
            factorial *= i;
        
        Console.WriteLine(factorial);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        extraLongFactorials(n);
    }
}
