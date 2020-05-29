// https://www.hackerrank.com/challenges/cavity-map/problem
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

    static string[] cavityMap(string[] grid) {

        for(int i = 1; i < grid.Length - 1; i++){
            for(int j = 1; j < grid[i].Length - 1; j++){
                char number = grid[i][j];
                if(number > grid[i+1][j] && number > grid[i-1][j] && number > grid[i][j+1] && number > grid[i][j-1])
                    grid[i] = grid[i].Substring(0, j) + 'X' + grid[i].Substring(j + 1, grid[i].Length - 1 - j);
            }
        }

        return grid;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string[] grid = new string [n];

        for (int i = 0; i < n; i++) {
            string gridItem = Console.ReadLine();
            grid[i] = gridItem;
        }

        string[] result = cavityMap(grid);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}