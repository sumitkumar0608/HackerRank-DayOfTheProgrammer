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

class Result
{

    /*
     * Complete the 'dayOfProgrammer' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER year as parameter.
     */

    public static string dayOfProgrammer(int year)
    {
        var day = 0;
        if (year <= 1917)
        {
            if (year % 4 == 0)
            {
                day = 256 - 244;
            }
            else
            {
                day = 256 - 243;
            }
        }
        else if (year >= 1919)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                //leap year
                day = 256 - 244;
            }
            else
            {
                day = 256 - 243;
            }
        }
        else
        {
            day = 256 - 230;
        }
        //string date = day.ToString();
        string completeDate = day.ToString() + ":" + "09:" + year.ToString(); 
        return completeDate;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.dayOfProgrammer(year);
        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
