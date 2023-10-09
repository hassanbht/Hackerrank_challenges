/*
 Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

Example

The minimum sum is  and the maximum sum is . The function prints

16 24 
*/

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        IOrderedEnumerable<int> nums =arr.OrderBy(i=>i);
        long minSum = CalculateMinimumSum(nums);
        long maxSum = CalculateMaximumSum(nums);
        Console.WriteLine($"{minSum} {maxSum}");
        Console.ReadLine();
    }

    private static long CalculateMaximumSum(IOrderedEnumerable<int> nums)
    {
        return  nums.Skip(1).Select(x => (long)x).Sum();
    }

    private static long CalculateMinimumSum(IOrderedEnumerable<int> nums)
    {

        return  nums.Take(4).Select(x => (long)x).Sum();
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}

