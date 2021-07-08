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

    // Complete the formingMagicSquare function below.
    static int formingMagicSquare(int[][] s) {
        int[,,] magic_mat = new int [8,3,3] {
                    {{8, 1, 6}, {3, 5, 7}, {4, 9, 2}},
                    {{6, 1, 8}, {7, 5, 3}, {2, 9, 4}},
                    {{4, 9, 2}, {3, 5, 7}, {8, 1, 6}},
                    {{2, 9, 4}, {7, 5, 3}, {6, 1, 8}}, 
                    {{8, 3, 4}, {1, 5, 9}, {6, 7, 2}}, 
                    {{4, 3, 8}, {9, 5, 1}, {2, 7, 6}}, 
                    {{6, 7, 2}, {1, 5, 9}, {8, 3, 4}}, 
                    {{2, 7, 6}, {9, 5, 1}, {4, 3, 8}},  
                };
        int minCost = 999;
        for(int k =0;k<8;k++)
        {
            int totalCost = 0;
            for (int i = 0; i < 3; i++) 
            {
                 for (int j = 0; j < 3; j++)
                 {
                     Console.WriteLine("Value of magic "+ magic_mat[k,i,j]);
                     Console.WriteLine("Value of actual "+  s[i][j]);
                     totalCost = totalCost + Math.Abs(magic_mat[k,i,j] - s[i][j]);
                 }
            }
            if(totalCost < minCost)
            {
                minCost = totalCost;
            }   
        }
        return minCost;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] s = new int[3][];

        for (int i = 0; i < 3; i++) {
            s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
        }

        int result = formingMagicSquare(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
