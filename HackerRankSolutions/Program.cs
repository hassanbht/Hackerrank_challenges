/*
Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
Print the decimal value of each fraction on a new line with  places after the decimal.
Note: This challenge introduces precision problems. The test cases are scaled to six decimal places,
though answers with absolute error of up to  are acceptable.

Example
There are  elements, two positive, two negative and one zero. Their ratios are ,  and . Results are printed as:
0.400000
0.400000
0.200000
*/

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;
        int n = arr.Count;
        foreach (int num in arr)
        {
            _ = num switch
            {
                > 0 => positiveCount++,
                0 => zeroCount++,
                < 0 => negativeCount++,
            };
        }

        decimal positiveRatio =(decimal) positiveCount / n;
        decimal negativeRatio =(decimal) negativeCount / n;
        decimal zeroRatio = (decimal) zeroCount / n;
        Console.WriteLine(positiveRatio.ToString("F6")); // Positive ratio with 6 decimal places
        Console.WriteLine(negativeRatio.ToString("F6")); // Negative ratio with 6 decimal places
        Console.WriteLine(zeroRatio.ToString("F6"));    // Zero ratio with 6 decimal places
        Console.ReadLine();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
