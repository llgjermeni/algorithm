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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {

       int[] alf = new int[26];
        int ops = 0;
        for(int i = 0; i < a.Length; ++i) 
        {
            alf[a[i] - 'a']++;
        }
        for(int i = 0; i < b.Length; ++i)
        {
             alf[b[i] - 'a']--;
        }
        foreach (int ana in alf)
        {
             ops += Math.Abs(ana);
        }
        return ops;


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
