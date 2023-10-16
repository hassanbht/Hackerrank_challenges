/* 
 Misère Nim hackerrank solution c#
Two people are playing game of Misère Nim. The basic rules for this game are as follows:

The game starts with n piles of stones indexed from 0 to n-1. Each pile  i (where 0<=i<n ) has si stones.
The players move in alternating turns. During each move, the current player must remove one or more stones from a single pile.
The player who removes the last stone loses the game.
Given the value of  and the number of stones in each pile, determine whether the person who wins the game is the first or second person to move. If the first player to move wins, print First on a new line; otherwise, print Second. Assume both players move optimally.

Function Description
misereNim has the following parameters:
int s[n]: the number of stones in each pile
Returns
string: either First or Second
 */

class Result
{

    /*
     * Complete the 'misereNim' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER_ARRAY s as parameter.
     */

    public static string misereNim(List<int> s)
    {
        if (s.Sum() == s.Count)
        {
            return s.Count % 2 == 0 ? "First" : "Second";
        }
        int nimSum = s.Aggregate((a, b) => a ^ b);
        return nimSum == 0 ? "Second" : "First";
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

            List<int> s = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string result = Result.misereNim(s);

            Console.WriteLine(result);
        }
    }
}
