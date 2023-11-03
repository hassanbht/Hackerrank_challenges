/*
 Gaming Array 1 hackerrank solution c#
Andy wants to play a game with his little brother, Bob. The game starts with an array of 
distinct integers and the rules are as follows:

Bob always plays first.
In a single move, a player chooses the maximum element in the array. He removes it and all elements to its right.
For example, if the starting array arr1=[2,3,5,4,1], then it becomes arr2=[2,3] after removing arr3=[5,4,1].
The two players alternate turns.
The last player who can make a move wins.
Andy and Bob play g games. Given the initial array for each game, find and print the name of the winner on a
new line. If Andy wins, print ANDY; if Bob wins, print BOB.

To continue the example above, in the next move Andy will remove 3. Bob will then remove 2 and win because 
there are no more integers to remove.

Function Description
gamingArray has the following parameter(s):
int arr[n]: an array of integers
Returns
- string: either ANDY or BOB

Input Format
The first line contains a single integer , the number of games.
Each of the next g pairs of lines is as follows:
The first line contains a single integer, n, the number of elements in arr.
The second line contains  distinct space-separated integers arr[i] where 0<=i<n.

*/

class Result
{

    /*
     * Complete the 'gamingArray' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static string gamingArray(List<int> arr)
    {
        int n = arr.Count;
        int maxElement = arr[0];
        int count = 0;

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > maxElement)
            {
                maxElement = arr[i];
                count++;
            }
        }

        // If the count is even, Bob wins; otherwise, Andy wins
        return count % 2 == 0 ? "BOB" : "ANDY";

    }

    public static string gamingArrayWithLINQ(List<int> arr)
    {        
        // If the count is even, Bob wins; otherwise, Andy wins
        return arr.Aggregate((count: 0, max: 0), (t, v) => v > t.max ? (t.count + 1, v) : t, t => t.count) % 2 == 0 ? "ANDY" : "BOB";
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        int g = Convert.ToInt32(Console.ReadLine()!.Trim());

        for (int gItr = 0; gItr < g; gItr++)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine()!.Trim());

            List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = Result.gamingArray(arr);

            Console.WriteLine(result);
        }
    }
}

