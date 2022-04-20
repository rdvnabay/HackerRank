using Implementation;

public class ViralAdvertising
{
    /// <param name="n"> int n: the day number to report </param>
    /// <returns> int: the cumulative likes at that day </returns>
    public static int Run(int n)
    {
        const int shareAdvertisingCount = 3;
        int shared = 5;
        int liked = 2;
        int currentCumulative, cumulative = 0;

        for (int i = 0; i < n; i++)
        {
            currentCumulative = shared / liked;
            shared = currentCumulative * shareAdvertisingCount;
            cumulative += currentCumulative;
        }

        return cumulative;
    }
}

