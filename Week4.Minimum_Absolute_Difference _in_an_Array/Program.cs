/* 
 Minimum Absolute Difference in an Array hackerrank solution c#
The absolute difference is the positive difference between two values  and a,b is written
|a-b| or |b-a| and they are equal. If a=3 and b=2,|3-2|=|2-3|=1 . Given an array of integers,
find the minimum absolute difference between any two elements in the array.
Function Description
 It should return an integer that represents the minimum absolute difference between any pair of elements.
minimumAbsoluteDifference has the following parameter(s):
int arr[n]: an array of integers
Returns
int: the minimum absolute difference found
*/

class Result
{

    /*
     * Complete the 'minimumAbsoluteDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int minimumAbsoluteDifferenceWithLINQ(List<int> arr)
    {
        arr.Sort();
        return arr.Zip(arr.Skip(1), (x, y) => Math.Abs(x - y)).Min();
    }

    public static int minimumAbsoluteDifference(List<int> arr)
    {
        arr.Sort();
        int minDiff = int.MaxValue;
        for (int i = 1; i < arr.Count; i++)
        {
            int diff = Math.Abs(arr[i] - arr[i - 1]);
            minDiff = Math.Min(diff, minDiff);
        }
        return minDiff;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.minimumAbsoluteDifferenceWithLINQ(arr);

        Console.WriteLine(result);
    }
}
