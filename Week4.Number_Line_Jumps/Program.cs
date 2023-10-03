/* 
 number line jumps hackerrank solution c#
You are choreographing a circus show with various animals. For one act,
you are given two kangaroos on a number line ready to jump in the positive direction 
(i.e, toward positive infinity).

The first kangaroo starts at location x1 and moves at a rate of v1 meters per jump.
The second kangaroo starts at location x2  and moves at a rate of  v2 meters per jump.

You have to figure out a way to get both kangaroos at the same location at the same time as part of the show.
If it is possible, return YES, otherwise return NO.
 */

class Result
{

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {       

        int distanceDiff = x2 - x1;
        int speedDiff = v1 - v2;

        if (speedDiff>0 && distanceDiff % speedDiff == 0 && distanceDiff / speedDiff >= 0)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }

    public static string kangarooV1(int x1, int v1, int x2, int v2)
    {
        if (v2 > v1) return "NO";
        while (x1 < x2)
        {
            x1 += v1;
            x2 += v2;

            if (x1 == x2) return "YES";
        }
        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
    }
}
