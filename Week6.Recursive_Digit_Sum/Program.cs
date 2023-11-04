/*
 Recursive Digit Sum hackerrank solution c#
We define super digit of an integer  using the following rules:
Given an integer, we need to find the super digit of the integer.
If x has only 1 digit, then its super digit is x.
Otherwise, the super digit of x is equal to the super digit of the sum of the digits of .
For example, the super digit of 9875 will be calculated as:

	super_digit(9875)   	9+8+7+5 = 29 
	super_digit(29) 	2 + 9 = 11
	super_digit(11)		1 + 1 = 2
	super_digit(2)		= 2  
Function Description

superDigit has the following parameter(s):
string n: a string representation of an integer
int k: the times to concatenate n to make p
Returns
int: the super digit of n repeated k times

Input Format
The first line contains two space separated integers,n  and k.
*/

using System.Linq;

class Result
{

    /*
     * Complete the 'superDigit' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING n
     *  2. INTEGER k
     */

    public static int superDigit(string n, int k)
    {
        int subSumm = 0;
        foreach (char nChar in n)
        {
            subSumm = (subSumm + k * int.Parse(nChar.ToString())) % 9;
        }

        return subSumm == 0 ? 9 : subSumm;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        string n = firstMultipleInput[0];

        int k = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.superDigit(n, k);

        Console.WriteLine(result);
    }
}
