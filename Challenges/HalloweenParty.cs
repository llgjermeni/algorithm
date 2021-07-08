using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    
      Complete the halloweenParty function below.
     
    static long halloweenParty(int k) {
       long m = 0;
       long n = 0;
       m = k  2;
       n = k - m;
       return m  n;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable(OUTPUT_PATH), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr  t; tItr++) {
            int k = Convert.ToInt32(Console.ReadLine());

            long result = halloweenParty(k);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
