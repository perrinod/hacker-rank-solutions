// https://www.hackerrank.com/challenges/grid-challenge/problem
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

    static string gridChallenge(string[] grid) {
        grid[0] = String.Concat(grid[0].OrderBy(c => c));

        for(int i = 1; i < grid.Length; i++){
            grid[i] = String.Concat(grid[i].OrderBy(c => c));

            for(int j = 0; j < grid[i].Length; j++){
                if(grid[i-1][j] > grid[i][j])
                    return "NO";
            }

        }

        return "YES";

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] grid = new string [n];

            for (int i = 0; i < n; i++) {
                string gridItem = Console.ReadLine();
                grid[i] = gridItem;
            }

            string result = gridChallenge(grid);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
