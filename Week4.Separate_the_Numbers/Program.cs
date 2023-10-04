/* 
 Separate the Numbers hackerrank solution c#
A numeric string, , is beautiful if it can be split into a sequence of two or more positive integers 
a[1],a[2],...,a[n] , satisfying the following conditions:

1. a[i] - a[i-1]=1 for 1<i<=n any  (i.e., each element in the sequence is 1 more than the previous element).
2. No a[i] contains a leading zero. For example, we can split s=10203 into the sequence {1,02,03}, but it is 
not beautiful because 02 and 03 have leading zeroes.
3. The contents of the sequence cannot be rearranged. For example, we can split  into the sequence {3,1,2},
but it is not beautiful because it breaks our first constraint (i.e.,1-3 !=1 ).

Perform q queries where each query consists of some integer string s. For each query, print whether or not
the string is beautiful on a new line. If it is beautiful, print YES x, where x is the first number of the 
increasing sequence. If there are multiple such values of x, choose the smallest. Otherwise, print NO.
 */

class Result
{

    /*
     * Complete the 'separateNumbers' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void separateNumbers(string s)
    {
        for (var i = 1; i <= s.Length / 2; i++)
        {
            var numStr = s.Substring(0, i);
            var num = long.Parse(numStr);
            var j = 0;
            while (j + numStr.Length <= s.Length && s.Substring(j, numStr.Length) == numStr)
            {
                j += numStr.Length;
                num++;
                numStr = num.ToString();
            }

            if (j == s.Length)
            {
                Console.WriteLine($"YES {s.Substring(0, i)}");
                return;
            }
        }

        Console.WriteLine("NO");
    }   
}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            Result.separateNumbers(s);
        }
    }
}
