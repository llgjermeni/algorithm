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

    // Complete the commonChild function below.
    static int commonChild(string s1, string s2) {
        int[,] mat = new int[s1.Length+1, s2.Length+1]; 
        for(int i=0; i<= s1.Length; i++)
        { 
            mat[i,0] = 0; mat[0,i] = 0;
        }
        for(int i = 0; i < s1.Length; i++)
        {
            for(int j = 0; j < s2.Length; j++)
            {
                if(s1[i] == s2[j]){
                    mat[i+1,j+1] = mat[i, j] + 1;
                }
                else{
                    mat[i+1,j+1] = mat[i+1, j] > mat[i, j+1] ? mat[i+1, j] : mat[i, j+1];
                }
            }
        }
        return mat[s1.Length, s1.Length];


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = commonChild(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
