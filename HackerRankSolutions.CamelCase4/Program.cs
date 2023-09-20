/*
 Camel Case is a naming style common in many programming languages. 
In Java, method and variable names typically start with a lowercase letter,
with all subsequent words starting with a capital letter (example: startThread).
Names of classes follow the same pattern, except that they start with a capital letter (example: BlueCar).

Your task is to write a program that creates or splits Camel Case variable, method, and class names.

Input Format

Each line of the input file will begin with an operation (S or C) followed by a semi-colon followed by M, C,
or V followed by a semi-colon followed by the words you'll need to operate on.
The operation will either be S (split) or C (combine)
M indicates method, C indicates class, and V indicates variable
In the case of a split operation, the words will be a camel case method,
class or variable name that you need to split into a space-delimited list of words starting with a lowercase letter.
In the case of a combine operation,
the words will be a space-delimited list of words starting with lowercase letters that you need to combine into the
appropriate camel case String. Methods should end with an empty set of parentheses to differentiate them from variable names.
Output Format

For each input line,
your program should print either the space-delimited list of words (in the case of a split operation) 
or the appropriate camel case string (in the case of a combine operation).
*/

using System.Text.RegularExpressions;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. 
          Your class should be named Solution */

        //CamelCaseV1();
        
        CamelCaseV2();

    }

    private static void CamelCaseV2()
    {
        List<string> initListString = new List<string>();
        const int maxLenght = 6;
        for (int i = 0; i < maxLenght; i++)
        {
            try { initListString.Add(Console.In.ReadLine()); }
            catch (Exception ex)
            {
                break;
            }
        }
        foreach (var item in initListString)
        {
            if (string.IsNullOrEmpty(item))
                return;

            var splitItem = item.Split(';');
            if (splitItem.Length > 3) return;
            char operation = splitItem[0][0];
            char type = splitItem[1][0];
            string words = splitItem[2];
            string result = string.Empty;
            if (operation == 'S')
                result = SplitMethod(words, type);
           else if (operation == 'C')
                result = CombineMethod(words, type);
            Console.WriteLine(result);
        }

    }

    private static string CombineMethod(string words, char type)
    {
        string result = string.Empty, data = string.Empty;

        var arrC = words.Split(' ');

        foreach (var item1 in arrC)
        {
            data += item1.Substring(0, 1).ToUpper() + item1.Substring(1, item1.Length - 1);
        }
        if (type == 'V' || type == 'M')
        {
            data = data.Substring(0, 1).ToLower() + data.Substring(1, data.Length - 1);
        }

        if (type == 'M')
            data = data + "()";

        result = data;
        return result;
    }

    private static string SplitMethod(string words, char type)
    {
        string result = string.Empty;
        string data = string.Empty;
        foreach (char key in words)
        {
            data = key.ToString();
            if (char.IsUpper(key))
            {
                data = " " + char.ToLower(key).ToString();
            }
            result += data;

            if (type == 'M' && words.Contains("()"))
                result = result.Replace("()", "");

            if (type == 'C')
                result = result.Trim();
        }
        return result;
    }

    private static void CamelCaseV1()
    {
        string? input = Console.ReadLine();
        while (!string.IsNullOrEmpty(input))
        {
            string[] parts = input.Split(';');
            char operation = parts[0][0];
            char type = parts[1][0];
            string words = parts[2];

            if (operation == 'S')
            {
                string splitWords = SplitCamelCase(words, type);
                Console.WriteLine(string.Join(" ", splitWords));
            }
            else if (operation == 'C')
            {
                string combinedWord = CombineCamelCase(words, type);
                Console.WriteLine(combinedWord);
            }
            input = Console.ReadLine();
        }
    }

    private static string CombineCamelCase(string words, char type)
    {
        string[] wordList = words.Split(' ');

        for (int i = 0; i < wordList.Length; i++)
        {
            if (i == 0 && type == 'C')
            {
                wordList[i] = char.ToUpper(wordList[i][0]) + wordList[i].Substring(1);
            }
            else if (i == 0 && type != 'C')
            {
                wordList[i] = char.ToLower(wordList[i][0]) + wordList[i].Substring(1);
            }
            else
            {
                wordList[i] = char.ToUpper(wordList[i][0]) + wordList[i].Substring(1);
            }
        }

        return string.Join("", wordList) + (type == 'M' ? "()" : "");

    }

    private static string SplitCamelCase(string words, char type)
    {
        string result = string.Empty;
        string[] splitResult = Regex.Replace(words, "(\\B[A-Z])", " $1").Split(' ');
        result = string.Join(" ", splitResult);
        if (type == 'M' && words.Contains("()"))
            result = result.Replace("()", "");

        if (type == 'C')
            result = result.Trim();

        return result;
    }

}

