/*
 sansa and xor hackerrank solution c#
 Sansa has an array. She wants to find the value obtained by XOR-ing the contiguous subarrays, 
followed by XOR-ing the values thus obtained. Determine this value.

Function Description
sansaXor has the following parameter(s):
int arr[n]: an array of integers
Returns
int: the result of calculations

*/

class Result
{

    /*
     * Complete the 'sansaXor' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int sansaXor(List<int> arr)
    {
        int result = 0;
        if (arr.Count % 2 == 0)
            return result;
        else
            for (int i = 0; i < arr.Count; i += 2)
                result ^= arr[i];
        return result;
    }

    public static int sansaXorLinq(List<int> arr)
    {
        int result = 0;
        if (arr.Count % 2 == 0)
            return result;
        else
            result = arr.Where((_, i) => i % 2 == 0).Aggregate(0, (agg, v) => agg ^ v);
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine()!.Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine()!.Trim());

            List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = Result.sansaXor(arr);

            Console.WriteLine(result);
        }
    }
}
