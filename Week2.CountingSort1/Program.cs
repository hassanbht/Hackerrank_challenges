/*
 Comparison Sorting

Quicksort usually has a running time of n x log(n), but is there an algorithm that can sort even faster? 
In general, this is not possible. Most sorting algorithms are comparison sorts, i.e.
they sort a list just by comparing the elements to one another. 
A comparison sort algorithm cannot beat n x log(n) (worst-case) running time, since n x log(n) 
represents the minimum number of comparisons needed to know where to place each element. For more details,
you can see these notes (PDF).

Alternative Sorting

Another sorting method, the counting sort, does not require comparison.
Instead, you create an integer array whose index range covers the entire range of values in your array to sort.
Each time a value occurs in the original array, you increment the counter at that index.
At the end, run through your counting array, printing the value of each non-zero valued index that number of times.

Example

arr = [1,1,1,3,2,1]
All of the values are in the range [0...3], 
so create an array of zeros result = [0,0,0,0]. 
The results of each iteration follow:

i   arr[i]  result
0   1   [0, 1, 0, 0]
1   1   [0, 2, 0, 0]
2   3   [0, 2, 0, 1]
3   2   [0, 2, 1, 1]
4   1   [0, 3, 1, 1]
The frequency array is [0,3,1,1]. These values can be used to create the sorted array as well:
sorted = [1,1,1,2,3].

Note

For this exercise, always return a frequency array with 100 elements.
The example above shows only the first 4 elements, the remainder being zeros.

Challenge

Given a list of integers, count and return the number of times each value appears as an array of integers.
*/
class Result
{

    /*
     * Complete the 'countingSort' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

public static List<int> countingSort(List<int> arr)
    {
        int[] result = new int[100];
        arr.ForEach(a => result[a]++);
        return result.ToList();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.countingSort(arr);

        Console.WriteLine(String.Join(" ", result));
    }
}
