/*
 Given an array of integers, where all elements but one occur twice, find the unique element.
Example [1,2,3,4,1,2,3]
The unique element is 4.
*/

class Result
{

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {
        int result = 0;
        var t = new List<int>();
        t.AddRange(a.Distinct());
        var r = a.Except(t);
        foreach (int num in a)
        {
            result ^= num;
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        Console.WriteLine(result);

    }
}
