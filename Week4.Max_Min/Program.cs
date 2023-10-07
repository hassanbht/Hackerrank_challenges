/* 
 Max Min hackerrank solution c# 
You will be given a list of integers, arr , and a single integer k. 
You must create an array of length k from elements of arr such that its unfairness is minimized.
Call that array arr1. Unfairness of an array is calculated as max(arr1)-min(arr1) 
where:
- max denotes the largest integer in arr1
- min denotes the smallest integer in arr1
Note: Integers in  may not be unique.
Function Description
maxMin has the following parameter(s):
int k: the number of elements to select
int arr[n]:: an array of integers
Returns
int: the minimum possible unfairness
 */

class Result
{

    /*
     * Complete the 'maxMin' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */

    public static int maxMin(int k, List<int> arr)
    {
        arr.Sort();
        int minUnfairness = int.MaxValue;
        for (int i = 0; i <= arr.Count - k; i++)
        {
            int unfairness = arr[i + k - 1] - arr[i];
            minUnfairness = Math.Min(minUnfairness, unfairness);
        }
        return minUnfairness;
    }
    public static int maxMinWithLINQ(int k, List<int> arr)
    {
        arr.Sort();
        int minUnFairness = int.MaxValue;
        for (int i = 0; i <= arr.Count - k; i++)
        {
            int result = arr.Skip(i).Take(k).Max() - arr.Skip(i).Take(k).Min();
            minUnFairness = Math.Min(minUnFairness, result);
        }
        return minUnFairness;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            arr.Add(arrItem);
        }

        int result = Result.maxMin(k, arr);

        Console.WriteLine(result);
    }
}
