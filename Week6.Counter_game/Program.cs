/*
 Counter game hackerrank solution c#
Louise and Richard have developed a numbers game. They pick a number and check to see if it is a power of 2.
If it is, they divide it by . If not, they reduce it by the next lower number which is a power of 2.
Whoever reduces the number to 1 wins the game. Louise always starts.

Given an initial value, determine who wins the game.
Update If they initially set counter to 1, Richard wins. Louise cannot make a move so she loses.
Function Description
counterGame has the following parameter(s):
int n: the initial game counter value
Returns
string: either Richard or Louise
Input Format
The first line contains an integer t, the number of testcases.
Each of the next  lines contains an integer n, the initial value for each game.
*/

class Result
{

    /*
     * Complete the 'counterGame' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static string counterGame(long n)
    {
        int turnCount = 0;
        if (n == 1) return "Richard";
        
        while (n > 1)
        {
            if ((n & (n - 1)) == 0) // Check if n is a power of 2
            {
                n /= 2;
            }
            else
            {
                long highestPowerOf2 = (long)Math.Pow(2, (int)Math.Floor(Math.Log(n, 2)));
                n -= highestPowerOf2;
            }

            turnCount++;
        }

        return (turnCount % 2 == 0) ? "Richard" : "Louise";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine()!.Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine()!.Trim());

            string result = Result.counterGame(n);

            Console.WriteLine(result);
        }
    }
}
