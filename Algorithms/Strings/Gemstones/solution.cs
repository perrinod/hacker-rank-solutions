// https://www.hackerrank.com/challenges/gem-stones/problem
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

    static int gemstones(string[] arr) {
        var rocks = new Dictionary<char,int>();

        for(int i = 0; i < arr.Length; i++){
            for(int j = 0; j < arr[i].Length; j++){
                if(!rocks.ContainsKey(arr[i][j]))
                    rocks.Add(arr[i][j], 0);
                    
                if(rocks[arr[i][j]] == i)
                    rocks[arr[i][j]]++;
            }
        }

        int count = 0;

        foreach(var gem in rocks){
            if(gem.Value == arr.Length)
                count++;
        }

        return count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string[] arr = new string [n];

        for (int i = 0; i < n; i++) {
            string arrItem = Console.ReadLine();
            arr[i] = arrItem;
        }

        int result = gemstones(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
