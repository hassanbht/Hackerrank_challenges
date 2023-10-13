/*
 Grid Challenge hackerrank solution c#
 Given a square grid of characters in the range ascii[a-z], rearrange elements of each row alphabetically,
 ascending. Determine if the columns are also in ascending alphabetical order, top to bottom.
 Return YES if they are or NO if they are not.

Function Description
gridChallenge has the following parameter(s):
string grid[n]: an array of strings
Returns
string: either YES or NO
*/

class Result
{

    /*
     * Complete the 'gridChallenge' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING_ARRAY grid as parameter.
     */

    public static string gridChallenge(List<string> grid)
    {
        int numRows = grid.Count;
        int numCols = grid[0].Length;

        char[][] gridChars = new char[numRows][];
        for (int i = 0; i < numRows; i++)
        {
            gridChars[i] = grid[i].ToCharArray();
            Array.Sort(gridChars[i]);
        }

        for (int col = 0; col < numCols; col++)
        {
            for (int row = 1; row < numRows; row++)
            {
                if (gridChars[row][col] < gridChars[row - 1][col])
                {
                    return "NO";
                }
            }
        }

        return "YES";        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine()!.Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine()!.Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine()!;
                grid.Add(gridItem);
            }

            string result = Result.gridChallenge(grid);

            Console.WriteLine(result);
        }
    }
}
