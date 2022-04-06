namespace Algorithms;

public class CompareTheTriplets
{
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

