namespace Warmup.Solutions;

public class CompareTheTriplets
{
    /// <param name="a"> Alice's challenge rating </param>
    /// <param name="b"> Bob's challenge rating </param>
    /// <returns> Alice's score is in the first position, and Bob's score is in the second </returns>
    public static List<int> Run(List<int> a, List<int> b)
    {
        var list = new List<int>();
        int scoreA = 0;
        int scoreB = 0;

        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
                scoreA++;
            else if (a[i] < b[i])
                scoreB++;
        }

        list.Add(scoreA);
        list.Add(scoreB);
        return list;
    }
}

