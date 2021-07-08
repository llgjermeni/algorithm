using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    // Complete the solve function below.
    static string solve(int[] a) {
        int x = a[0];
                for(int i=1;i<a.Length;i++)
                {
                        x = gcd(x, a[i]);
                        if (x==1)
                        {
                            return "YES";
                        }
                }
                return "NO";
        }

        private static int gcd(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a == 0 ? b : a;
        }

        /*
         int x = a[0];
                for(int i=1;i<a.Length;i++)
                {
                        x = gcd(x, a[i]);
                        if (x==1)
                        {
                            return "YES";
                        }
                }
                return "NO"; */

   

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int aCount = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            string result = solve(a);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
