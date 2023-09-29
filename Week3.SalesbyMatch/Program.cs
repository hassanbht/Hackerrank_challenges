/*
 There is a large pile of socks that must be paired by color. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
Function Description
int n: the number of socks in the pile
int ar[n]: the colors of each sock
Returns
int: the number of pairs
*/
class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        int countPairs = 0;
        List<int> sockCounts = new List<int>();        
        foreach (int i in ar)
        {
            if(sockCounts.Contains(i))
            {
                countPairs++;
                sockCounts.Remove(i);
            }
            else
                sockCounts.Add(i);
        }
        return countPairs;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> ar = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        Console.WriteLine(result);
    }
}
