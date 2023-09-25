/*
 In this HackerRank Permuting Two Arrays problem solution there are two n element arrays of integers A and B.
we need to permute them into some A' and B' such that the relation A'[i] + B'[i] >= k holds
for all I where 0 <= I < n. and there are q queries consisting of A, B, and k.
for each query return YES if some permutation A'.B' satisfying the relation exists.
otherwise, return NO.
*/
class Result
{

    /*
     * Complete the 'twoArrays' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY A
     *  3. INTEGER_ARRAY B
     */

public static string twoArrays(int k, List<int> A, List<int> B)
    {
        A.Sort();
        B.Sort();
        B.Reverse();
        for (int i = 0; i < A.Count; i++)
        {
            if (A[i] + B[i] < k)
                return "NO";
        }
        return "YES";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            string result = Result.twoArrays(k, A, B);

            Console.WriteLine(result);
        }

    }
}
