//https://www.hackerrank.com/challenges/migratory-birds/problem
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

    static int migratoryBirds(List<int> arr) {

        int[] birds = new int[5];

        for(int i = 0; i < arr.Count; i++){
            birds[arr[i]-1]++;
        }
    
        int highest, index;
        highest = index = 0;

        for(int i = 0; i < birds.Length; i++){
            if(highest < birds[i]){
                highest = birds[i];
                index = i + 1;
            }
        }
    
        return index;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}