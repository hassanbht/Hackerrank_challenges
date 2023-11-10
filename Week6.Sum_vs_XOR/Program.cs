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
            // Convert the Value to a string in base 2
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
