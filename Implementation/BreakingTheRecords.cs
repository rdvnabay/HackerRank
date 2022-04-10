namespace Implementation;

public class BreakingTheRecords
{
    /// <summary>
    /// Maria plays college basketball and wants to go pro. Each season she maintains a record of her play. 
    /// She tabulates the number of times she breaks her season record for most points and least points in a game. 
    /// Points scored in the first game establish her record for the season, and she begins counting from there.
    /// </summary>
    /// <param name="scores"> [10 5 20 20 4 5 2 25 1] </param>
    /// <returns> 2 4 </returns>
    
    public static List<int> Run(List<int> scores)
    {
        List<int> result = new();
        int goodPerformanceRecord = 0;
        int badPerformanceRecord = 0;
        int minScore = 0;
        int maxScore = 0;
 
        for(int i = 0; i < scores.Count; i++)
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

