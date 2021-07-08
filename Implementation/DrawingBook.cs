using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int totalPages (int m)
    {
        return (m + 2) / 2;
    }
    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        
        int total = totalPages(n);

        int startPage = totalPages(p) - 1;
        int endPage = total - startPage - 1;

        return Math.Min(startPage, endPage);
        
        /* other solution 
        int total = n/2;
        int right = p/2;
        int left = total - right;
        if(right < left){
            return right;
        }
        else {
            return left;
        }
 */

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
