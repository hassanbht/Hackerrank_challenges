/*
 Sum vs XOR hackerrank solution c#
Given an integer n, find each x such that:
0<=x<=n
n+x=n xor x
 Return the number of x's satisfying the criteria.

Function Description
sumXor has the following parameter(s):
- int n: an integer
Returns
- int: the number of values found
Input Format
A single integer, n.
*/
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
using System.Numerics;

class Result
{

    /*
     * Complete the 'sumXor' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long sumXor(long n)
    {
        return n == 0 ? 1 : (long)BigInteger.Pow(2,
            // Convert the Int64 value to a string in base toBase
            Convert.ToString(n, 2)
            .Count(c => c == '0'));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        long n = Convert.ToInt64(Console.ReadLine()!.Trim());

        long result = Result.sumXor(n);

        Console.WriteLine(result);
    }
}
