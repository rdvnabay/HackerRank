namespace Implementation.Solutions;

public class FindDigits
{
    /// <param name="n"> int n: the value to analyze </param>
    /// <returns> int: the number of digits in n that are divisors of n </returns>
    public static int Run(int n)
    {
        int originNumber = n;
        int divisibleCount = 0;

        while (n > 0)
        {
            int remainder = n % 10;

            if (remainder != 0)
                if (originNumber % remainder == 0)
                    divisibleCount++;

            n /= 10;
        }
        return divisibleCount;
    }
}