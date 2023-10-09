/*
 Strong Password hackerrank solution c#
Louise joined a social networking site to stay in touch with her friends.
The signup page required her to input a name and a password. However, the password must be strong. 
The website considers a password to be strong if it satisfies the following criteria:

Its length is at least 6.
It contains at least one digit.
It contains at least one lowercase English character.
It contains at least one uppercase English character.
It contains at least one special character. The special characters are: !@#$%^&*()-+
She typed a random string of length  in the password field but wasn't sure if it was strong.
Given the string she typed, can you find the minimum number of characters she must add to make her password strong?
Note: Here's the set of types of characters in a form you can paste in your solution:

numbers = "0123456789"
lower_case = "abcdefghijklmnopqrstuvwxyz"
upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
special_characters = "!@#$%^&*()-+"

Function Description
minimumNumber has the following parameters:
int n: the length of the password
string password: the password to test
Returns
int: the minimum number of characters to add
  */

class Result
{

    /*
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    public static int minimumNumber(int n, string password)
    {
        // Return the minimum number of characters to make the password strong
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";
        int missingTypes = 0;
        if (!password.Any(p => numbers.Contains(p)))
            missingTypes++;
        if (!password.Any(p => lower_case.Contains(p)))
            missingTypes++;
        if (!password.Any(p => upper_case.Contains(p)))
            missingTypes++;
        if (!password.Any(p => special_characters.Contains(p)))
            missingTypes++;
        if (n < 6)
        {
            return Math.Max(6 - n, missingTypes);
        }
        return missingTypes;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()!.Trim());

        string password = Console.ReadLine()!;

        int answer = Result.minimumNumber(n, password);

        Console.WriteLine(answer);
    }
}
