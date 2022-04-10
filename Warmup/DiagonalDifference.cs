namespace Warmup;

public class DiagonalDifference
{
    /*
     Given a square matrix, calculate the absolute difference between the sums of its diagonals.
     For example, the square matrix arr is shown below: 
      11 2 4
       4 5 6
      10 8 -12
     */
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

