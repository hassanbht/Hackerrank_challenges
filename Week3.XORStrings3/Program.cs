using System.Text;

namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            var s = Console.ReadLine().TrimEnd().ToCharArray();
            var t = Console.ReadLine().TrimEnd().ToCharArray();
            Console.WriteLine(strings_xor(s, t));
        }

        private static string strings_xor(char[] s, char[] t)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
                sb.Append((s[i] ^ t[i]));
            return sb.ToString();
        }

        private static string strings_xor(string str1, string str2)
        {
            string result = string.Empty;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    result += "1";
                else
                    result += "0";

            }
            return result;
        }
    }
}