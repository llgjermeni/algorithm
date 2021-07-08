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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {

        var pNumbers = 0;
        var nNumbers = 0;
        var zNumbers = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > 0)
            {
                ++pNumbers;
            }else if(arr[i] < 0)
            {
                ++nNumbers;
            }else
            {
                ++zNumbers;
            }
            
        }
            Console.WriteLine((double)pNumbers / arr.Length);
            Console.WriteLine((double)nNumbers / arr.Length);
            Console.WriteLine((double)zNumbers / arr.Length);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
