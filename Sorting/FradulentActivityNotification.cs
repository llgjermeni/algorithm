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

    // Complete the activityNotifications function below.
    static int activityNotifications(int[] expenditure, int d) {
        int n = 0;
        var arr = new int[d];
        Array.Copy(expenditure, arr, d);
        Array.Sort(arr);

        for(int i = d; i < expenditure.Length; i++)
        {
            if(expenditure[i] >= arr[d / 2] + arr[(d - 1) / 2])
            {
                n++;
            }
        
            int index = Array.BinarySearch(arr, expenditure[i - d]);
            Array.Copy(arr, index + 1, arr, index, d - index - 1);
            index = Array.BinarySearch(arr, 0, d -1, expenditure[i]);
            index = index >= 0 ? index : ~index;
            Array.Copy(arr, index, arr, index + 1, d - index - 1);
            arr[index] = expenditure[i];
        }

        return n;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] expenditure = Array.ConvertAll(Console.ReadLine().Split(' '), expenditureTemp => Convert.ToInt32(expenditureTemp))
        ;
        int result = activityNotifications(expenditure, d);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
