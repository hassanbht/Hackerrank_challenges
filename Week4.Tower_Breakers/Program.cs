/* 
 Tower Breakers hackerrank solution c#
 Two players are playing a game of Tower Breakers! Player 1 always moves first, 
and both players always play optimally.The rules of the game are as follows:

Initially there are n towers.
Each tower is of height m.
The players move in alternating turns.
In each turn, a player can choose a tower of height x and reduce its height to y, 
where 1<=y<x and y evenly divides x.
If the current player is unable to make a move, they lose the game.
Given the values of n and m, determine which player will win. If the first player wins,
return 1. Otherwise, return 2.
Function Description
towerBreakers has the following paramter(s):
int n: the number of towers
int m: the height of each tower
Returns
int: the winner of the game
 */

class Result
{

    /*
     * Complete the 'towerBreakers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER m
     */

    public static int towerBreakers(int n, int m)
    {
        //all towers have height 1, player 2 wins 
        // If the height of each tower is divisible by 2, player 2 wins
        return (m == 1 || n % 2 == 0) ? 2 : 1;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = Result.towerBreakers(n, m);

            Console.WriteLine(result);
        }
    }
}
