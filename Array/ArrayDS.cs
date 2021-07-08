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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
     int max = -100500;
        int temp = 0;
        
        for (int i = 1; i <= 4; ++i)
        {
            for (int j = 1; j <= 4; ++j)
            {
                temp =     arr[i - 1][j + 1] +              + arr[i + 1][j + 1] +
                           arr[i - 1][j]     + arr[i][j] + arr[i + 1][j] +
                           arr[i - 1][j - 1] +              + arr[i + 1][j - 1];
                max = Math.Max(max, temp);
            }
        }

        return max;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
