//https://www.hackerrank.com/challenges/library-fine/problem
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

    static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2) {
        int nd, nm, ny;
    
        nd = d1 - d2;
        nm = m1 - m2;
        ny = y1 - y2;
    
        if((y1 <= y2 && m1 <= m2 && d1 <= d2) || y1 < y2 || (y1 <= y2 && m1 < m2))
            return 0;
        else if(ny >= 1)
            return 10000;
        else if(nm >= 1)
            return 500 * nm;
        else
            return Math.Abs(nd) * 15;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] d1M1Y1 = Console.ReadLine().Split(' ');

        int d1 = Convert.ToInt32(d1M1Y1[0]);

        int m1 = Convert.ToInt32(d1M1Y1[1]);

        int y1 = Convert.ToInt32(d1M1Y1[2]);

        string[] d2M2Y2 = Console.ReadLine().Split(' ');

        int d2 = Convert.ToInt32(d2M2Y2[0]);

        int m2 = Convert.ToInt32(d2M2Y2[1]);

        int y2 = Convert.ToInt32(d2M2Y2[2]);

        int result = libraryFine(d1, m1, y1, d2, m2, y2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
