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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr) {

        long min = long.MaxValue;
        long max = long.MinValue;
        long sum = 0;
        foreach(var i in arr)
        {
            //Console.WriteLine(i);
            min = Math.Min(min, i);
            max = Math.Max(max, i);
            sum += i;
        }
        Console.WriteLine($"{sum - max} {sum - min}");
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
