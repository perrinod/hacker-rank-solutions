//https://www.hackerrank.com/challenges/time-conversion/problem
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static string timeConversion(string s) {
        string meridian = s.Substring(s.Length - 2);
        string ms = s.Substring(2, s.Length - 4);
        int hour = Int32.Parse(s.Substring(0,2));

     hour = ((meridian == "AM" && hour == 12) ? 0 : (meridian == "PM" && hour != 12) ? (hour + 12) : hour);

        return ((hour < 12) ? ('0' + hour.ToString()) : hour.ToString()) + ms;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
