/*
 Two children, Lily and Ron, want to share a chocolate bar. Each of the squares has an integer on it.
Lily decides to share a contiguous segment of the bar selected such that:
The length of the segment matches Ron's birth month, and,
The sum of the integers on the squares is equal to his birth day.
Determine how many ways she can divide the chocolate.
[2,2,1,3,2]
Lily wants to find segments summing to Ron's birth day, d=4 with a length equalling his birth month,
m=2. In this case, there are two segments meeting her criteria:  [2,2]and [1,3].
Returns
int: the number of ways the bar can be divided
*/
class Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int count = 0;

        for (int i = 0; i <= s.Count - m; i++)
        {
            int sum = 0;

            for (int j = 0; j < m; j++)
            {
                sum += s[i + j];
            }

            if (sum == d)
            {
                count++;
            }
        }

        return count;
    }


    public static int birthdayWithLINQ(List<int> s, int d, int m)
    {
        int count = 0;
        for (int i = 0; i <= s.Count - m; i++)
        {
            if (s.GetRange(i, m).Sum() == d)
                count++;            
        }
        return count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        List<int> s = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int d = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        int result = Result.birthdayWithLINQ(s, d, m);

        Console.WriteLine(result);
    }
}
