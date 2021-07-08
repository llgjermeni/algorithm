/*
Not optimized version of Stair Case

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



class Solution
{
    // Function definition 
    static void pattern(int n)
    {
        // for loop for rows 
        for (int i = 1; i <= n; i++)
        {

            // conditional operator 
            int k;

            if (i % 1 != 0)
                k = i + 1;
            else
                k = i;

            // for loop for  
            // printing spaces 
            for (int g = n; g > k; g--)
                Console.Write(" ");
            // according to value of k carry 
            // out further operation 
            for (int j = 0; j < k; j++)
                Console.Write("# ");
            Console.WriteLine();
        }
    }

    // Driver code 
    public static void Main()
    {
        int n = 4;
        pattern(n);
    }
}

 */

 /*Optimized version of Stair Case */

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

    // Complete the staircase function below.
    static void staircase(int n) {
        
         for (int i = 1; i <= n; i++)

        {

            var s = new String(' ', n - i);

            var h = new String('#', i);

            Console.WriteLine(s + h);

        }

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
