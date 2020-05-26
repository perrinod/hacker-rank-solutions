// https://www.hackerrank.com/challenges/3d-surface-area/problem
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

    static int surfaceArea(int[][] A) {
        int area = 0;

        for(int i = 0; i < A.Length; i++){
            for(int j = 0; j < A[i].Length; j++){
                area += 4 * A[i][j] + 2;

                if(i + 1 < A.Length)
                    area -= 2 * Math.Min(A[i][j], A[i + 1][j]);

                if(j + 1 < A[i].Length)
                    area -= 2 * Math.Min(A[i][j], A[i][j + 1]);
            }   
        }

        return area;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] HW = Console.ReadLine().Split(' ');

        int H = Convert.ToInt32(HW[0]);

        int W = Convert.ToInt32(HW[1]);

        int[][] A = new int[H][];

        for (int i = 0; i < H; i++) {
            A[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));
        }

        int result = surfaceArea(A);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
