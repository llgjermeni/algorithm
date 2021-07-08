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

    // Complete the substrCount function below.
    static long substrCount(int n, string s) {
        long count = 0;
        for(int i=0;i<n;i++) {
            char ch = s[i];
            int j = i+1;
            while(j<n && s[j]==ch) { 
                count++; j++;
            }
            if(j<n) {        
                int mid = j;   
                j++;
                int eq = mid-i; 
                while(j<n && j<=mid+eq && s[j] == ch) { 
                    j++;
                }
                if(j-1-mid==mid-i) {
                    count++;
                }
            }
        }
        return count+n;


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        long result = substrCount(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
