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
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        return s.ToLower().Where(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26 ? "pangram" : "not pangram";
    }

    public static string pangramsWithRegex(string s)
    {
        Regex regex = new Regex(@"([a-z])(?!.*\1)", RegexOptions.IgnoreCase);
        MatchCollection matches = regex.Matches(s);

        return matches.Count == 26 ? "pangram" : "not pangram";      
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        Console.WriteLine(result);
    }
}
