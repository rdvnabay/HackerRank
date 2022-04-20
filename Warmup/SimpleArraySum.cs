namespace Warmup;

public class SimpleArraySum
{
    /// <param name="ar"> an array of integers </param>
    /// <returns> the sum of the array's elements </returns>
    public static int Run(List<int> ar)
    {
        int total = 0;
        foreach (var i in ar)
        {
            total += i;
        }
        return total;
    }
}

