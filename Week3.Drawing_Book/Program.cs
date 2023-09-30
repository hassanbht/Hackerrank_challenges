/*
 Drawing Book hackerrank solution c#
 A teacher asks the class to open their books to a page number. 
A student can either start turning pages from the front of the book or from the back of the book.
They always turn pages one at a time. When they open the book, page 1 is always on the right side:

When they flip page , they see pages 2 and 3. Each page except the last page will always be printed on both sides.
The last page may only be printed on the front, given the length of the book. If the book is n pages long,
and a student wants to turn to page p, what is the minimum number of pages to turn?
They can start at the beginning or the end of the book.

Given n and p, find and print the minimum number of pages that must be turned in order to arrive at page .
pageCount has the following parameter(s):
int n: the number of pages in the book
int p: the page number to turn to
Returns
int: the minimum number of pages to turn
*/

class Result
{

    /*
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
        int totalPageTurns = n / 2;
        int targetPageTurns = p / 2;

        if (targetPageTurns <= totalPageTurns / 2)
        {
            return targetPageTurns;
        }
        else
        {
            return totalPageTurns - targetPageTurns;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        Console.WriteLine(result);
    }
}
