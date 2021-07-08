using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string time) {
        /*
         * Write your code here.
         */
        DateTime date = Convert.ToDateTime(time);
        string hour   = Convert.ToString(date.Hour);
        hour = hour.PadLeft(2,'0');
        string minute = Convert.ToString(date.Minute);
        minute = minute.PadLeft(2, '0');
        string second = Convert.ToString(date.Second);
        second = second.PadLeft(2, '0');

        string result = hour + ":" + minute + ":" + second;
        Console.WriteLine(result);
        return result;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
