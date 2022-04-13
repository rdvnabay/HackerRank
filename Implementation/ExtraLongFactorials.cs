using System.Numerics;

namespace Implementation;

public class ExtraLongFactorials
{
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