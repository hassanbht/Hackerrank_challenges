/*
  A space explorer's ship crashed on Mars! They send a series of SOS messages to Earth for help.

 Letters in some of the SOS messages are altered by cosmic radiation during transmission.
 Given the signal received by Earth as a string, 
 determine how many letters of the SOS message have been changed by radiation.
*/
class Result
{

    /*
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

public static int marsExploration(string s)
    {
        var alteredCharCount = 0;
        var sosSignal = "SOS";
        var index = 0;
        foreach (var c in s)
        {
            if ((char)c != sosSignal[index++])
                alteredCharCount++;

            if (index % 3 == 0)
                index = 0;
        }
        return alteredCharCount;
    }

    public static int marsExplorationWithFor(string s)
    {
        int alteredCount = 0;

        for (int i = 0; i < s.Length; i += 3)
        {
            if (s[i] != 'S')
            {
                alteredCount++;
            }
            if (s[i + 1] != 'O')
            {
                alteredCount++;
            }
            if (s[i + 2] != 'S')
            {
                alteredCount++;
            }
        }

        return alteredCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        Console.WriteLine(result);
    }
}
