namespace Implementation.Solutions;

public class BeautifulDaysAtTheMovies
{
    /// <param name="i"> int i: the starting day number </param>
    /// <param name="j"> int j: the ending day number </param>
    /// <param name="k"> int k: the divisor </param>
    /// <returns> int: the number of beautiful days in the range </returns>
    public static int Run(int i, int j, int k)
    {
        int numberOfIntegerValues = 0;
        int reverseNumber = 0;
        double result;

        Console.WriteLine(20 - '0');

        for (int number = i; number <= j; number++)
        {
            reverseNumber = number.ToString()
                .Reverse()
                .Aggregate(0, (sum, next) => 10 * sum + next - '0');

            result = Math.Abs((double)(number - reverseNumber) / (double)k);

            if (result - (int)result == 0)
                numberOfIntegerValues++;
        }

        return numberOfIntegerValues;
    }
}

