/*
 You will be given a list of 32 bit unsigned integers. Flip all the bits (1→0 and 0→1) and
 return the result as an unsigned integer.
*/
class Result
{

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {        
        return (long)(Math.Pow(2, 32) - 1 - n);
    }
    public static long flippingBits1(long n)
    {
        uint res = 0;
        for (int i = 0; i < 32; i++)
        {
            int bit = (int)(n & 1);
            res += (uint)((1 - bit) << i);
            n >>= 1;
        }
        return res;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            Console.WriteLine(result);
        }
    }
}
