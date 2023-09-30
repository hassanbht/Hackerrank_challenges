/*
 Zig Zag Sequence  hackerrank solution c#
 In this challenge, the task is to debug the existing code to successfully execute all provided test files.

Given an array of  distinct integers, transform the array into a zig zag sequence by permuting the array elements.
A sequence will be called a zig zag sequence if the first  elements in the sequence are in increasing order 
and the last k elements are in decreasing order, where k=(n+1)/2. You need to find the lexicographically 
smallest zig zag sequence of the given array.

Input Format
The first line contains  the number of test cases. The first line of each test case contains an integer ,
denoting the number of array elements. The next line of the test case contains  elements of array a.

Output Format
For each test cases, print the elements of the transformed zig zag sequence in a single line.
 */

class Result
{  
    public static List<int> findZigZagSequence(List<int> a, int n)
    {
        a.Sort();
        int mid = (n + 1) / 2 - 1;
        int temp = a[mid];
        a[mid] = a[n - 1];
        a[n - 1] = temp;

        int st = mid + 1;
        int ed = n - 2;
        while (st <= ed)
        {
            temp = a[st];
            a[st] = a[ed];
            a[ed] = temp;
            st = st + 1;
            ed = ed - 1;
        }
        return a;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(t => Convert.ToInt32(t)).ToList();

        List<int> result = Result.findZigZagSequence(a, n);

        Console.WriteLine(String.Join(" ", result));
    }
}