namespace DynamicProgramming.Solutions;

public class FibonacciModified
{
    public static int Run(int t1, int t2, int n)
    {
        int prev = 0;
        int next = 1;
        var result = prev + (int)Math.Sqrt(t2);

        foreach (var item in Enumerable.Range(0, n - 3))
        {
            t1 = next + prev;
            result = t1 + (int)Math.Sqrt(result);

        }

        return 0;
    }
}
