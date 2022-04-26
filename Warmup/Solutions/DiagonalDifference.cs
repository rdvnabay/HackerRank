namespace Warmup.Solutions;

public class DiagonalDifference
{
    /// <param name="arr"> an array of integers </param>
    /// <returns> the absolute diagonal difference </returns>
    public static int Run(List<List<int>> arr)
    {
        int scoreA = 0;
        int scoreB = 0;
        int positionB = arr.Count - 1;

        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if (i == j)
                    scoreA += arr[i][j];

                if (positionB == j)
                {
                    scoreB += arr[i][j];
                    positionB--;
                }
            }
        }
        return Math.Abs(scoreB - scoreA);
    }
}

