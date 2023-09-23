/*
    An avid hiker keeps meticulous records of their hikes. During the last hike that took exactly  steps,
    for every step it was noted if it was an uphill, , or a downhill,  step. Hikes always start and end at sea level,
    and each step up or down represents a  unit change in altitude. We define the following terms:

    A mountain is a sequence of consecutive steps above sea level,
    starting with a step up from sea level and ending with a step down to sea level.
    A valley is a sequence of consecutive steps below sea level,
    starting with a step down from sea level and ending with a step up to sea level.
    Given the sequence of up and down steps during a hike,
    find and print the number of valleys walked through.
*/
class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

public static int countingValleys(int steps, string path)
    {
        int level = 0; // Current altitude level
        int valleyCount = 0; // Number of valleys walked through
        bool isInValley = false; // Flag to track if currently in a valley

        foreach (char step in path)
        {
            if (step == 'U')
            {
                level++; // Step up
            }
            else if (step == 'D')
            {
                level--; // Step down
            }

            if (level < 0 && !isInValley)
            {
                isInValley = true; // Entered a valley
            }

            if (level == 0 && isInValley)
            {
                valleyCount++; // Exited a valley
                isInValley = false;
            }
        }
        return valleyCount;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        Console.WriteLine(result);
    }
}
