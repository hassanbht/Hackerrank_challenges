/*
 Dynamic Array hackerrank solution c#
Declare a 2-dimensional array, arr , of  empty arrays. All arrays are zero indexed.
Declare an integer,lastAnswer , and initialize it to 0.

There are 2 types of queries, given as an array of strings for you to parse:

Query: 1 x y
Let idx=((x xor lastAnswer) %n).
Append the integer y to arr[idx].
Query: 2 x y
Let  idx=((x xor lastAnswer) %n).
Assign the value arr[idx][y%size(arr[idx])]  to lastAnswer.
Store the new value of lastAnswer to an answers array.
Note:  is the bitwise XOR operation, which corresponds to the ^ operator in most languages.
Learn more about it on Wikipedia.% is the modulo operator.
Finally, size(arr[idx]) is the number of elements in arr[idx]

Function Description

Complete the dynamicArray function below.

dynamicArray has the following parameters:
- int n: the number of empty arrays to initialize in arr
- string queries[q]: query strings that contain 3 space-separated integers

Returns
int[]: the results of each type 2 query in the order they are presented
*/

class Result
{

    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<int>[] arr = new List<int>[n];
        int lastAnswer = 0;
        List<int> answers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            arr[i] = new List<int>();
        }

        foreach (var query in queries)
        {
            int type = query[0];
            int x = query[1];
            int y = query[2];

            int idx = (x ^ lastAnswer) % n;

            if (type == 1)
            {
                arr[idx].Add(y);
            }
            else if (type == 2)
            {
                int size = arr[idx].Count;
                int elementIdx = y % size;
                lastAnswer = arr[idx][elementIdx];
                answers.Add(lastAnswer);
            }
        }

        return answers;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = Result.dynamicArray(n, queries);

        Console.WriteLine(String.Join("\n", result));
    }
}
