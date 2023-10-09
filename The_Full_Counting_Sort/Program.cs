/*
 The Full Counting Sort hackerrank solution c#
 Use the counting sort to order a list of strings associated with integers.
If two strings are associated with the same integer, they must be printed in their original order, 
i.e. your sorting algorithm should be stable. There is one other twist:
strings in the first half of the array are to be replaced with the character - (dash, ascii 45 decimal).

Insertion Sort and the simple version of Quicksort are stable, but the faster in-place version
of Quicksort is not since it scrambles around elements while sorting.

Design your counting sort to be stable.

Function Description
countSort has the following parameter(s):
string arr[n][2]: each arr[i] is comprised of two strings, x and s
Returns
- Print the finished array with each element separated by a single space.
Note: The first element of each arr[i],x, must be cast as an integer to perform the sort.

*/

class Result
{

    /*
     * Complete the 'countSort' function below.
     *
     * The function accepts 2D_STRING_ARRAY arr as parameter.
     */

    public static void countSort(List<List<string>> arr)
    {
        int count = 0;
        List<KeyValuePair<int, string>> list = new();
        arr.ForEach(item =>
        {
            if (count < arr.Count / 2)
            {
                list.Add(new KeyValuePair<int, string>(Convert.ToInt32(item[0]), "-"));

            }
            else
            {
                list.Add(new KeyValuePair<int, string>(Convert.ToInt32(item[0]), item[1].ToString()));
            }
            count++;
        });
        list.OrderBy(x => x.Key).ToList().ForEach(item =>
        {
            Console.Write(item.Value + " ");
        });
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine()!.TrimEnd().Split(' ').ToList());
        }

        Result.countSort(arr);
    }
}
