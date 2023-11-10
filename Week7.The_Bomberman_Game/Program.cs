/*
 The Bomberman Game hackerrank solution c#
Bomberman lives in a rectangular grid. Each cell in the grid either contains a bomb or nothing at all.

Each bomb can be planted in any cell of the grid but once planted, it will detonate after exactly 3 seconds. 
Once a bomb detonates,
it's destroyed — along with anything in its four neighboring cells.
This means that if a bomb detonates in cell i,j, any valid cells (i+1,j) and (i,j+1) are cleared.
If there is a bomb in a neighboring cell, the neighboring bomb is destroyed without detonating,
so there's no chain reaction.

Bomberman is immune to bombs, so he can move freely throughout the grid. Here's what he does:

Initially, Bomberman arbitrarily plants bombs in some of the cells, the initial state.
After one second, Bomberman does nothing.
After one more second, Bomberman plants bombs in all cells without bombs, thus filling the whole grid with bombs. 
No bombs detonate at this point.
After one more second, any bombs planted exactly three seconds ago will detonate. 
Here, Bomberman stands back and observes.
Bomberman then repeats steps 3 and 4 indefinitely.
Note that during every second Bomberman plants bombs, 
the bombs are planted simultaneously (i.e., at the exact same moment), and any bombs planted 
at the same time will detonate at the same time.

Given the initial configuration of the grid with the locations of Bomberman's first batch of planted bombs,
determine the state of the grid after N seconds.

Function Description
bomberMan has the following parameter(s):
int n: the number of seconds to simulate
string grid[r]: an array of strings that represents the grid
Returns
string[r]: n array of strings that represent the grid in its final state
Input Format
The first line contains three space-separated integers r,c , and n, The number of rows,
columns and seconds to simulate.
Each of the next r lines contains a row of the matrix as a single string of c characters. The .
character denotes an empty cell, and the O character (ascii 79) denotes a bomb.
*/

using System.Text;

class Result
{

    /*
     * Complete the 'bomberMan' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING_ARRAY grid
     */

    public static List<string> bomberMan(int n, List<string> grid)
    {
        // Special cases for seconds 1
        if (n == 1) return grid;

        if (n % 2 == 0)
        {
            plantGrid(grid);
        }
        else
        {
            // Determine the state of the grid after 3 seconds
            List<string> bombMap = grid.ToList();
            plantGrid(grid);           
            detonateGrid(grid, bombMap);
            if ((n - 1) % 4 == 0)
            {
                bombMap = grid.ToList();
                plantGrid(grid);
                detonateGrid(grid, bombMap);
            }
        }

        return grid;
    }

    // Helper method to detonate bombs and update the grid and bomb placement
    public static void detonateGrid(List<string> grid, List<string> bombMap)
    {
        int n = grid.Count;
        int m = grid[0].Length;
        char bomb = 'O';

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (bombMap[i][j] == bomb)
                {
                    grid[i] = replaceCharAtIndex(grid[i], j, '.');
                    if (i - 1 >= 0) grid[i - 1] = replaceCharAtIndex(grid[i - 1], j, '.');
                    if (j - 1 >= 0) grid[i] = replaceCharAtIndex(grid[i], j - 1, '.');
                    if (i + 1 < n) grid[i + 1] = replaceCharAtIndex(grid[i + 1], j, '.');
                    if (j + 1 < m) grid[i] = replaceCharAtIndex(grid[i], j + 1, '.');
                }
            }
        }
    }

    // Helper method to place bombs in empty cells and update the grid and bomb placement
    public static void plantGrid(List<string> grid)
    {
        for (int i = 0; i < grid.Count; i++)
        {
            grid[i] = new string('O', grid[0].Length);
        }
    }

    public static string replaceCharAtIndex(string s, int i, char c)
    {
        StringBuilder sb = new StringBuilder(s);
        sb[i] = c;
        return sb.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int r = Convert.ToInt32(firstMultipleInput[0]);

        int c = Convert.ToInt32(firstMultipleInput[1]);

        int n = Convert.ToInt32(firstMultipleInput[2]);

        List<string> grid = new List<string>();

        for (int i = 0; i < r; i++)
        {
            string gridItem = Console.ReadLine()!;
            grid.Add(gridItem);
        }

        List<string> result = Result.bomberMan(n, grid);

        Console.WriteLine(String.Join("\n", result));
    }
}
