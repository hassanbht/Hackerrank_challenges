/*
 Maximum Perimeter Triangle hackerrank solution c#
 Given an array of stick lengths, use 3 of them to construct a non-degenerate triangle 
 with the maximum possible perimeter. Return an array of the lengths of its sides as 3 integers
 in non-decreasing order.

 If there are several valid triangles having the maximum perimeter:

 Choose the one with the longest maximum side.
 If more than one has that maximum, choose from them the one with the longest minimum side.
 If more than one has that maximum as well, print any one them.
 If no non-degenerate triangle exists, return [-1].
*/

class Result
{

    /*
     * Complete the 'maximumPerimeterTriangle' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY sticks as parameter.
     */

    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        sticks.Sort();

        for (int i = sticks.Count - 1; i >= 2; i--)
        {
            int side1 = sticks[i - 2];
            int side2 = sticks[i - 1];
            int side3 = sticks[i];

            if (side1 + side2 > side3)
            {
                return new List<int> { side1, side2, side3 };
            }
        }

        return new List<int> { -1 };
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> sticks = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sticksTemp => Convert.ToInt32(sticksTemp)).ToList();

        List<int> result = Result.maximumPerimeterTriangle(sticks);

        Console.WriteLine(String.Join(" ", result));
    }
}
