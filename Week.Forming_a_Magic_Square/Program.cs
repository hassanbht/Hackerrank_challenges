/*
 Forming a Magic Square hackerrank solution c#
We define a magic square to be an n*n matrix of distinct positive integers from 1 to n^2 where the sum of any row,
column, or diagonal of length n is always equal to the same number: the magic constant.

You will be given a 3*3 matrix s of integers in the inclusive range [1,9].
We can convert any digit a to any other digit b in the range [1,9] at cost of |a-b|. 
Given s, convert it into a magic square at minimal cost. Print this cost on a new line.

Note: The resulting magic square must contain distinct integers in the inclusive range [1,9].

Function Description
formingMagicSquare has the following parameter(s):
int s[3][3]: a 3*3 array of integers
Returns
int: the minimal total cost of converting the input square to a magic square
Input Format

Each of the 3 lines contains three space-separated integers of row s[i].
*/

class Result
{

    /*
     * Complete the 'formingMagicSquare' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY s as parameter.
     */

    public static int formingMagicSquare(List<List<int>> s)
    {
        int[][][] possibleMagicSquares = new int[][][]
    {
        new int[][] { new int[] { 8, 1, 6 }, new int[] { 3, 5, 7 }, new int[] { 4, 9, 2 } },
        new int[][] { new int[] { 6, 1, 8 }, new int[] { 7, 5, 3 }, new int[] { 2, 9, 4 } },
        new int[][] { new int[] { 4, 9, 2 }, new int[] { 3, 5, 7 }, new int[] { 8, 1, 6 } },
        new int[][] { new int[] { 2, 9, 4 }, new int[] { 7, 5, 3 }, new int[] { 6, 1, 8 } },
        new int[][] { new int[] { 8, 3, 4 }, new int[] { 1, 5, 9 }, new int[] { 6, 7, 2 } },
        new int[][] { new int[] { 4, 3, 8 }, new int[] { 9, 5, 1 }, new int[] { 2, 7, 6 } },
        new int[][] { new int[] { 6, 7, 2 }, new int[] { 1, 5, 9 }, new int[] { 8, 3, 4 } },
        new int[][] { new int[] { 2, 7, 6 }, new int[] { 9, 5, 1 }, new int[] { 4, 3, 8 } },
    };

        int minCost = int.MaxValue;
     
        // Iterate through each possible magic square
        foreach (int[][] magicSquare in possibleMagicSquares)
        {
            int cost = 0;

            // Calculate the cost of converting s to the current magic square
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cost += Math.Abs(s[i][j] - magicSquare[i][j]);
                }
            }

            // Update the minimum cost if necessary
            minCost = Math.Min(minCost, cost);
        }

        return minCost;
    }

   }

class Solution
{
    public static void Main(string[] args)
    {
        List<List<int>> s = new List<List<int>>();

        for (int i = 0; i < 3; i++)
        {
            s.Add(Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
        }

        int result = Result.formingMagicSquare(s);

        Console.WriteLine(result);
    }
}

