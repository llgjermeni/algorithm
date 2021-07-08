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

    /// First solution
    // static bool Fall(int start, int end, int a, int b)
    // {
    //     int d = a + b;
    //     return !(d < start || d > end);
    // }

    // // Complete the countApplesAndOranges function below.
    // static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
    //     Console.WriteLine(apples.Where(x => Fall(s,t,a,x)).Count());
    //     Console.WriteLine(oranges.Where(x => Fall(s,t,b,x)).Count());

    // }

    ///second solution
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
            var apCount = 0;
            var orCount = 0;

            for(int i = 0; i < apples.Length; i++)
            {
                if(a + apples[i] >= s && a + apples[i] <= t)
                {
                    apCount++;
                }
            }

            for(int i = 0; i < oranges.Length; i++)
            {
                if(b + oranges[i] >= s && b + oranges[i] <= t)
                {
                    orCount++;
                }
            }
        Console.WriteLine($"{apCount}");
        Console.WriteLine($"{orCount}");
    }
    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
