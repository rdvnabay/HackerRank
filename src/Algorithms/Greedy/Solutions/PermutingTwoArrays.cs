namespace Greedy.Solutions;

public class PermutingTwoArrays
{
    public static string Run(int k, List<int> A, List<int> B)
    {
        var orderedA = A.OrderBy(x => x).ToList();
        var orderedB = B.OrderByDescending(x => x).ToList();

        for (int i = 0; i < A.Count; i++)
        {
            if (orderedA[i] + orderedB[i] < k)
                return "NO";
        }

        return "YES";
    }
}