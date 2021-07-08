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

    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar) {
         Array.Sort(ar);
        int result = 1;
        int value = 2;
        while((value <= ar.Length) && (ar[ar.Length-1] == ar[ar.Length-value])){
            result++;
            value++;
        }
        return result;


    }
    /* other version
    static int birthdayCakeCandles(int[] ar) {
        int max = ar.Max();
        int count = ar.Count(a => a == max);
        return count;
    }
     */

     /* new version
      static int birthdayCakeCandles(int[] ar) {
        int max = 0;
        int count = 0;

        for(int i = 0; i < ar.Length; i++)
        {
            if(max < ar[i])
            {
                max = ar[i];
                
            }
        }

        for(int i = 0; i < ar.Length; i++)
        {
            if(ar[i] == max)
            {
                
                count++;
            }
        }
        return count;
    }
      */

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
