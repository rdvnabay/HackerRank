namespace Implementation;

public class BeautifulDaysAtTheMovies
{
    /// <param name="i"> int i: the starting day number </param>
    /// <param name="j"> int j: the ending day number </param>
    /// <param name="k"> int k: the divisor </param>
    /// <returns> int: the number of beautiful days in the range </returns>
    public static int Run(int i, int j, int k)
    {
        int numberOfIntegerValues = 0;

        for (int number = i; number <= j; number++)
        {
            int reverseNumber = int.Parse(number.ToString()
                 .Reverse()
                 .Aggregate("", (s, c) => s + c));

            double result = Math.Abs((double)(number - reverseNumber) / (double)k);

            if (result - (int)result == 0)
                numberOfIntegerValues++;
        }

        return numberOfIntegerValues;
    }
}

