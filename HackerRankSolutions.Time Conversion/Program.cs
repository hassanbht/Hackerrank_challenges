/*
 Given a time in -hour AM/PM format, convert it to military (24-hour) time.
Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
Returns
string: the time in 24 hour format
*/

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversionV1(string s)
    {
        // Extract the hour, minutes, and seconds from the input string
        int hour = int.Parse(s.Substring(0,2));
        int minutes = int.Parse(s.Substring(3,2));
        int seconds = int.Parse(s.Substring(6,2));
        bool isMorning = s.Substring(8, 2) == "AM";

        // Check if it's a PM time and adjust the hour accordingly
        if (!isMorning && hour!=12)
        {
            hour += 12;
        }

        // For midnight (12:00:00AM), adjust the hour to 00:00:00
        if (isMorning && hour == 12)
        {
            hour = 0;
        }

        // Create the new formatted time string
        string formattedTime = $"{hour:D2}:{minutes:D2}:{seconds:D2}";

        return formattedTime;
    }

    public static string timeConversionV2(string s)
    {
        DateTime formattedTime = DateTime.Parse(s);

        return formattedTime.ToString("HH:mm:ss");
    }

}

class Solution
{
    public static void Main(string[] args)
    {    
        string s = Console.ReadLine();

        string result = Result.timeConversionV2(s);

        Console.WriteLine(result);
    }
}
