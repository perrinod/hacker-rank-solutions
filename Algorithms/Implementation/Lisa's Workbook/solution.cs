//https://www.hackerrank.com/challenges/lisa-workbook/problem
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

    static int workbook(int n, int k, int[] arr) {
        int count = 0, page = 1;

        foreach(int problems in arr){
            for(int i = 1; i <= problems; i++){
                if(i == page)
                    count++;
                if(i % k == 0)
                    page++;
            }
            if(problems % k != 0)
                page++;
        }

        return count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = workbook(n, k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
