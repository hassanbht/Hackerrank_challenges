class Result
{

    /*
    Maria plays college basketball and wants to go pro.
    Each season she maintains a record of her play.
    She tabulates the number of times she breaks her season record for most points and least points in a game.
    Points scored in the first game establish her record for the season, and she begins counting from there.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        int minRecordBreaks = 0;
        int maxRecordBreaks = 0;

        if (scores.Count > 1)
        {
            int maxScore = scores[0];
            int minScore = scores[0];

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                    maxRecordBreaks++;
                }

                if (scores[i] < minScore)
                {
                    minScore = scores[i];
                    minRecordBreaks++;
                }
            }
        }
        return new List<int> { maxRecordBreaks, minRecordBreaks };
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));

    }
}