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

    // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice) {
        
        int[] rankarr = new int[alice.Length];
        
        int l = scores.Length;

            int rank = 1;
            for(int i = scores.Length-1; i > 0; i--){
                    if (scores[i] < scores[i-1]) rank++;
                    }
            rank++;
            int j = l-1;
            for(int i=0;i<alice.Length;i++){

                while(alice[i] >= scores[j]){
                if(rank==1) break;
                if(j!=0) {
                    if (scores[j] == scores[j - 1]) j--;
                    else {

                        j--;
                        rank--;
                    }
                }
                else rank--;
            }
            rankarr[i]=rank;
            }
        return rankarr;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int scoresCount = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int aliceCount = Convert.ToInt32(Console.ReadLine());

        int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), aliceTemp => Convert.ToInt32(aliceTemp))
        ;
        int[] result = climbingLeaderboard(scores, alice);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
