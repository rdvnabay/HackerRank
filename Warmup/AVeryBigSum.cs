namespace Warmup;
public class AVeryBigSum
{
    /*
     In this challenge, you are required to calculate and print the sum of the elements in an array,
     keeping in mind that some of those integers may be quite large.
     */
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

