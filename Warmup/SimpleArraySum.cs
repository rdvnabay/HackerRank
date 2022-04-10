namespace Warmup;

public class SimpleArraySum
{
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

