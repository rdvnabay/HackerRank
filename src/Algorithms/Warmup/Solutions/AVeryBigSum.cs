namespace Warmup.Solutions;

public class AVeryBigSum
{
    /// <param name="ar"> an array of integers </param>
    /// <returns> the sum of all array elements </returns>
    public static long Run(List<long> ar)
    {
        long total = 0;
        foreach (var val in ar)
        {
            total += val;
        }
        return total;
    }
}

