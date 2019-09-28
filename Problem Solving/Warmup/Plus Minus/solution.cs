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

    static void plusMinus(int[] arr) {
        double positive, negative, zero;
        positive = negative = zero = 0;

        for(int i = 0; i < arr.Length; i++){
            if(arr[i] > 0) positive++;
            else if(arr[i] < 0) negative++;
            else zero++;
        }
        
        Console.WriteLine(positive / arr.Length + "\n" + negative / arr.Length + "\n" + zero / arr.Length);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
