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

    // Complete the isValid function below.
    static string isValid(string s) {
         Dictionary<char, int> a = new Dictionary<char, int>();
        Dictionary<int, int> b = new Dictionary<int, int>();

        // Count char frequencies
        for (int i = 0; i < s.Length; i++)
        {
            if (a.ContainsKey((char)s[i]))
                a[(char)s[i]] += 1;
            else
                a.Add((char)s[i], 1);
        }

        // Count frequency pairs
        for (int i = 0; i < a.Count; i++)
        {
            int val = a.ElementAt(i).Value;
            if (!b.ContainsKey(val))
                b.Add(val, 1);
            else
                b[val] += 1;
        }

        // If b > 2 indexes -> string is invalid
        if (b.Count > 2)
            return "NO";
        // If b == 1 index -> string is ok
        else if (b.Count == 1)
            return "YES";

        // Sort on highest frequency 
        var p = b.ToList();
        p.Sort((p1, p2) => p2.Value.CompareTo(p1.Value));

        // Remove 1 from both key and value
        int k = p.ElementAt(1).Key - 1;
        int v = p.ElementAt(1).Value - 1;

        // If smallest frequency is 0 or match high frequency, string is ok.
        return (v == 0 && k == 0 || (v == 0 && k == p.ElementAt(0).Key)) ? "YES" : "NO";



    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = isValid(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
