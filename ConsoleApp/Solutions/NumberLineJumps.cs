namespace Solutions;

public class NumberLineJumps
{
    /// <param name="x1"> starting position for kangaroo 1 </param>
    /// <param name="v1"> jump distance for kangaroo 1 </param>
    /// <param name="x2"> starting position for kangaroo 2 </param>
    /// <param name="v2"> jump distance for kangaroo 2 </param>
    /// <returns> either YES or NO </returns>
    public static string Run(int x1, int v1, int x2, int v2)
    {
        string result = "";
        int startingPointDiff = 0;
        int stepDiff = 0;
        int distanceDiffBetween = 0;

        if (x1 > x2)
            startingPointDiff = x1 - x2;
        else if (x1 < x2)
            startingPointDiff = x2 - x1;

        if (v1 > v2)
            stepDiff = v1 - v2;
        else if (v1 < v2)
            stepDiff = v2 - v1;

        int firstKangaroo = x1 + v1;
        int secondKangaroo = x2 + v2;
        distanceDiffBetween = startingPointDiff - stepDiff;


        if (x1 < x2 && v1 < v2 || x1 > x2 && v1 > v2)
            result = "NO";

        else if (x1 != x2 && v1 == v2)
            result = "NO";

        else
        {
            do
            {
                if (firstKangaroo == secondKangaroo)
                {
                    result = "YES";
                    break;
                }

                else
                {
                    firstKangaroo += v1;
                    secondKangaroo += v2;
                    distanceDiffBetween -= stepDiff;

                    if (distanceDiffBetween < 0)
                    {
                        result = "NO";
                        break;
                    }
                }
            }
            while (firstKangaroo != secondKangaroo);

            if (firstKangaroo == secondKangaroo)
                result = "YES";
        }

        return result;
    }
}

