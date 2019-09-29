//https://www.hackerrank.com/challenges/staircase/problem
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

    static void staircase(int n) {
        for(int i = 1; i < n + 1; i++){
            string spaces = new String(' ', n - i);
            string hashtag = new String('#', i);
            Console.WriteLine(spaces + hashtag);
        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}