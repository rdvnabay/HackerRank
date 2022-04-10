namespace Implementation;

public class NumberLineJumps
{
    /// <summary>
    /// You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity).
    /// The first kangaroo starts at location and moves at a rate of meters per jump.
    /// The second kangaroo starts at location and moves at a rate of meters per jump.
    /// You have to figure out a way to get both kangaroos at the same location at the same time as part of the show.If it is possible, return YES, otherwise return NO.
    /// </summary>

    /// <param name="x1">first kangaroo start position</param>
    /// <param name="v1">first kangaroo number of steps</param>
    /// <param name="x2">second kangaroo start position</param>
    /// <param name="v2">second kangaroo number of steps</param>
    /// <returns>"YES" or "NO"</returns>

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

