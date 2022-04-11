using Implementation;

public class ViralAdvertising
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"> 3 </param>
    /// <returns> 9 </returns>
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

