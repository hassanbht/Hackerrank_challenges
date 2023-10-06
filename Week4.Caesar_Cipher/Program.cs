/* 
 Caesar Cipher hackerrank solution c#
Julius Caesar protected his confidential information by encrypting it using a cipher. 
Caesar's cipher shifts each letter by a number of letters. If the shift takes you past the end of the alphabet,
just rotate back to the front of the alphabet. In the case of a rotation 
by 3, w, x, y and z would map to z, a, b and c.

Original alphabet:      abcdefghijklmnopqrstuvwxyz
Alphabet rotated +3:    defghijklmnopqrstuvwxyzabc

Function Description
caesarCipher has the following parameter(s):
string s: cleartext
int k: the alphabet rotation factor
Returns
string: the encrypted string
*/

using System.Text;

class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        StringBuilder encrypted = new StringBuilder();

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
                char encryptedChar = (char)(((c - baseChar + k) % 26) + baseChar);
                encrypted.Append(encryptedChar);
            }
            else
            {
                encrypted.Append(c);
            }
        }
        return encrypted.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        Console.WriteLine(result);
    }
}
