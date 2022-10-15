namespace Implementation.Solutions;

public class SubarrayDivision
{
    /// <param name="s"> the numbers on each of the squares of chocolate </param>
    /// <param name="d"> Ron's birth day </param>
    /// <param name="m"> Ron's birth month </param>
    /// <returns> the number of ways the bar can be divided </returns>
    public static int Run(List<int> s, int d, int m)
    {
        int startRange = 0;
        int endRange = m - 1;
        int counter = 0;
        int total = 0;

        for (int i = 0; i < s.Count; i++)
        {
            total += s[i];
            if (i == endRange)
            {
                if (total == d)
                    counter++;

                startRange++;
                endRange++;
                i = startRange - 1;
                total = 0;
            }
        }
        return counter;
    }
}
