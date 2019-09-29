//https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
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

    static int[] breakingRecords(int[] scores) {
        int highest, lowest, highTotal, lowTotal;
        highest = lowest = scores[0];
        highTotal = lowTotal = 0;
        for(int i = 0; i < scores.Length; i++){
            if(highest < scores[i]){
                highest = scores[i];
                highTotal++;
            }
            if(lowest > scores[i]){
                lowest = scores[i];
                lowTotal++;
            }
        }

        return new int[] {highTotal, lowTotal};
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
