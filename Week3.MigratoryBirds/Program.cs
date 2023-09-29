/*
    Migratory Birds hackerrank solution
    Given an array of bird sightings where every element represents a bird type id, determine the id of the most frequently sighted type. If more than 1 type has been spotted that maximum amount, return the smallest of their ids.
    Function Description
    int arr[n]: the types of birds sighted
    Returns
    int: the lowest type id of the most frequently sighted birds
*/
class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        int maxCount = 0;
        int mostFrequentBird=int.MaxValue;
        Dictionary<int,int> result = new Dictionary<int,int>();
        foreach (int birdId in arr)
        {
            if (result.ContainsKey(birdId))
                result[birdId]++;
            else
                result[birdId] = 1;
            if (result[birdId] > maxCount)
            {
                maxCount = result[birdId];
                mostFrequentBird = birdId;
            }
            else if (result[birdId] == maxCount && birdId < mostFrequentBird)
                mostFrequentBird = birdId;
        }
        return mostFrequentBird;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        Console.WriteLine(result);
    }
}
