namespace Solutions;

public class BreakingTheRecords
{
    /// <param name="scores"> points scored per game </param>
    /// <returns> int[2]: An array with the numbers of times she broke her records. 
    /// Index 0 is for breaking most points records,
    /// and index 1 is for breaking least points records. </returns>
    public static List<int> Run(List<int> scores)
    {
        List<int> result = new();
        int goodPerformanceRecord = 0;
        int badPerformanceRecord = 0;
        int minScore = 0;
        int maxScore = 0;

        for (int i = 0; i < scores.Count; i++)
        {
            if (i == 0)
            {
                minScore = scores[i];
                maxScore = scores[i];
            }

            if (scores[i] < minScore)
            {
                badPerformanceRecord++;
                minScore = scores[i];

            }

            else if (scores[i] > maxScore)
            {
                goodPerformanceRecord++;
                maxScore = scores[i];
            }
        }

        result.Add(goodPerformanceRecord);
        result.Add(badPerformanceRecord);
        return result;
    }
}

