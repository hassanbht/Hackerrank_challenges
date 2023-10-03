/*
 Left Rotation hackerrank solution c#
 A left rotation operation on an array of size n shifts each of the array's elements 1 unit to the left.
Given an integer, d, rotate the array that many steps left and return the result.
Function Description
rotateLeft has the following parameters:
int d: the amount to rotate by
int arr[n]: the array to rotate
Returns
int[n]: the rotated array
*/

class Result
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> rotateLeftWithLINQ(int d, List<int> arr)
    {
        var listSkip=arr.Skip(d).ToList();
        listSkip.InsertRange(arr.Count - d, arr.Take(d));
        return listSkip;
    }

    public static List<int> rotateLeft(int d, List<int> arr)
    {
        int n = arr.Count;
        int[] rotatedArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            int newIndex = (i + n - d) % n;
            rotatedArr[newIndex] = arr[i];
        }

        return rotatedArr.ToList();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int d = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.rotateLeftWithLINQ(d, arr);

        Console.WriteLine(String.Join(" ", result));
    }
}
