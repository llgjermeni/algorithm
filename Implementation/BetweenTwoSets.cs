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

class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int total = 0;
        int number = a.Max();

        Enumerable.Range(number, b.Min())
            .ToList()
            .ForEach(n => 
            { 
                if (a.All(e => number % e == 0 || e % number == 0)
                    && b.All(e => number  % e == 0 || e %number == 0))
                    total++;

                number++;
            });

        return total;

    }

    /* other solution
    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;
        for(int k = 1; k <= 100; k++)
        {
            int x = 1;
            for(int i = 0; i < a.Count; i++)
            {
                if(k % a[i] != 0)
                {
                    x =0;
                }
            }
            for(int i = 0; i < b.Count; i++)
            {
                if(b[i] % k != 0)
                {
                    x = 0;
                }
            }

            if(x == 1)
            {
                count++;
            }
        }
        return count;
    }
     */

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        textWriter.WriteLine(total);

        textWriter.Flush();
        textWriter.Close();
    }
}
