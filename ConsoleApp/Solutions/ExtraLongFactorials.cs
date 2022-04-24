using System.Numerics;

namespace Solutions;

public class ExtraLongFactorials
{
    /// <param name="n"> n: an integer </param>
    public static void Run(int n)
    {
        BigInteger factorial = 1;
        for (int i = n; i >= 1; i--)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}