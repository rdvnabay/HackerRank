namespace Implementation;

public class SherlockAndSquares
{
    /// <param name="a"> int a: the lower range boundary </param>
    /// <param name="b"> int b: the upper range boundary </param>
    /// <returns> int: the number of square integers in the range </returns>
    public static int Run(int a, int b)
    {
        int numberOfSquareIntegersInTheRange = 0;

        for (int i = a; i <= b; i++)
        {
            if (Math.Sqrt(i) % 1 == 0)
                numberOfSquareIntegersInTheRange++;

        }

        return numberOfSquareIntegersInTheRange;
    }
}
