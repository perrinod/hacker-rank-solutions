//https://www.hackerrank.com/challenges/counting-valleys/problem
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

    static int countingValleys(int n, string s) {
        int valley, count;
        valley = count = 0;
        bool downhill = false;

        for(int i = 0; i < n; i++){
            if(s[i] == 'U')
            valley++;
            else
            {
                if(valley == 0)
                    downhill = true;

                valley--;
            }
        
            if(valley == 0 && downhill){
                count++;
                downhill = !downhill;
            }
        }

        return count;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
