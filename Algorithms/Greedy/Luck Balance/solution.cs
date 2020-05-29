// https://www.hackerrank.com/challenges/luck-balance/problem
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

    static int luckBalance(int k, int[][] contests) {
        int luck = 0;
        Comparer<int> comparer = Comparer<int>.Default;
        Array.Sort<int[]>(contests, (a,b) => comparer.Compare(a[0], b[0]));

        for(int i = contests.Length - 1; i >= 0; i--){
            if(contests[i][1] == 1){
                if(k > 0){
                    luck += contests[i][0];
                    k--;
                }
                else
                    luck -= contests[i][0];
            }
            else
                luck += contests[i][0];
        }

        return luck;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[][] contests = new int[n][];

        for (int i = 0; i < n; i++) {
            contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
        }

        int result = luckBalance(k, contests);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}