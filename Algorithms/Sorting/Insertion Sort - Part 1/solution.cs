//https://www.hackerrank.com/challenges/insertionsort1/problem
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

    static void insertionSort1(int n, int[] arr) {
        int insertValue = arr[n- 1];
        int j = n - 2;

        while(j >= 0){
            if(insertValue < arr[j])
                arr[j + 1] = arr[j];
            else
                break;
            j--;
            Console.WriteLine(string.Join(" ", arr));
        }

        arr[j + 1] = insertValue;
        Console.WriteLine(string.Join(" ", arr));

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        insertionSort1(n, arr);
    }
}