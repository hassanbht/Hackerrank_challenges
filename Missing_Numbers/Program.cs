/*
 Missing Numbers hackerrank solution c#
Given two arrays of integers, find which elements in the second array are missing from the first array.
Notes
If a number occurs multiple times in the lists, you must ensure that the frequency of 
that number in both lists is the same. If that is not the case, then it is also a missing number.
Return the missing numbers sorted ascending.
Only include a missing number once, even if it is missing multiple times.
The difference between the maximum and minimum numbers in the original list is less than or equal to 100.

Function Description
missingNumbers has the following parameter(s):
int arr[n]: the array with missing numbers
int brr[m]: the original array of numbers
Returns
int[]: an array of integers

 */

class Result
{

    /*
     * Complete the 'missingNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY arr
     *  2. INTEGER_ARRAY brr
     */

    public static List<int> missingNumbers(List<int> arr, List<int> brr)
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        brr.ForEach(i =>
        {
            freqMap.TryAdd(i, 0);
            freqMap[i]++;
        });
        arr.ForEach(i =>
        {
            freqMap.TryAdd(i, 0);
            freqMap[i]--;
        });
        var missingNumbers = freqMap.Where(c => c.Value != 0).Select(c => c.Key).ToList();
        missingNumbers.Sort();
        return missingNumbers;
    }

    public static List<int> missingNumbersShort(List<int> arr, List<int> brr)
    {
        var result = brr.Distinct().Where(x => !arr.Contains(x) || arr.Count(a => a == x) != brr.Count(b => b == x)).ToList();
        result.Sort();
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int m = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> brr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        List<int> result = Result.missingNumbers(arr, brr);

        Console.WriteLine(String.Join(" ", result));
    }
}
