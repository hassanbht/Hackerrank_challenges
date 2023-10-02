/*
    picking numbers hackerrank solution c#
    Given an array of integers, find the longest subarray where the absolute difference between 
    any two elements is less than or equal to 1.

    Function Description
    pickingNumbers has the following parameter(s):
    int a[n]: an array of integers
    Returns
    int: the length of the longest subarray that meets the criterion
 */

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {        
        int currentLength = 1, maxLength = 0, pos = 0;
        a.Sort();
        for (int i = 1; i < a.Count; i++)
        {
            if ((a[i] - a[pos]) <= 1)
            {
                currentLength++;
            }
            else
            {
                maxLength = Math.Max(currentLength, maxLength);
                pos = i;
                currentLength = 1;
            }
        }
        maxLength = Math.Max(currentLength, maxLength);

        return maxLength;     
    }    
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        Console.WriteLine(result);
    }
}

