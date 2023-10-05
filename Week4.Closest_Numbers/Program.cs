/* 
 Closest Numbers hackerrank solution c#
 Sorting is useful as the first step in many different tasks. 
The most common task is to make finding things easier, but there are other uses as well. In this case,
it will make it easier to determine which pair or pairs of elements have the smallest absolute difference between
them.

Note
As shown in the example, pairs may overlap.

Given a list of unsorted integers, , find the pair of elements that have the smallest absolute difference
between them. If there are multiple pairs, find them all.

Function Description
closestNumbers has the following parameter(s):
int arr[n]: an array of integers
Returns
- int[]: an array of integers as described
 */

class Result
{

    /*
     * Complete the 'closestNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> closestNumbers(List<int> arr)
    {
        arr.Sort();
        int minDiff = int.MaxValue;
        List<int> result = new List<int>();
        for (int i = 1; i < arr.Count; i++)
        {
            int diff = Math.Abs(arr[i] - arr[i - 1]);
            if (diff < minDiff)
            {
                minDiff = diff;
                result.Clear();
                result.Add(arr[i - 1]);
                result.Add(arr[i]);
            }
            else if (diff == minDiff)
            {
                result.Add(arr[i - 1]);
                result.Add(arr[i]);
            }
        }
        return result;
    }

    public static List<int> closestNumbersWithLINQ(List<int> arr)
    {
        arr.Sort();
        List<int> result = new List<int>();
        var differences = arr.Zip(arr.Skip(1), (x, y) => new closestNumbersResult { first = x, second = y, minDiff = y - x }).ToList();
        var minDifference = differences.MinBy(r => r.minDiff);
        var finallist = differences.Where(r=>r.minDiff == minDifference!.minDiff).ToList();
        foreach (var item in finallist)
        {
            result.Add(item.first);
            result.Add(item.second);
        }
        return result;
    }

}

class closestNumbersResult
{
    public int first { get; set; }
    public int second { get; set; }
    public int minDiff { get; set; }
}
class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.closestNumbersWithLINQ(arr);

        Console.WriteLine(String.Join(" ", result));
    }
}
