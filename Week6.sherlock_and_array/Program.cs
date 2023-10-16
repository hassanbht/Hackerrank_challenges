/*
 sherlock and array hackerrank solution c#
Watson gives Sherlock an array of integers. His challenge is to find an element of the array such that 
the sum of all elements to the left is equal to the sum of all elements to the right.
Function Description
balancedSums has the following parameter(s):
int arr[n]: an array of integers
Returns
string: either YES or NO
*/

class Result
{

    /*
     * Complete the 'balancedSums' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static string balancedSums(List<int> arr)
    {
        int n = arr.Count;
        int totalSum = arr.Sum();
        int leftSum = 0;

        for (int i = 0; i < n; i++)
        {
            if (leftSum == totalSum - arr[i] - leftSum)
            {
                return "YES";
            }

            leftSum += arr[i];
        }

        return "NO";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine()!.Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine()!.Trim());

            List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.balancedSums(arr);

            Console.WriteLine(result);
        }
    }
}
