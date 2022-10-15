namespace Implementation.Solutions;

public class SherlockAndSquares
{
    /// <param name="a"> int a: the lower range boundary </param>
    /// <param name="b"> int b: the upper range boundary </param>
    /// <returns> int: the number of square integers in the range </returns>
    public static int Run(int a, int b)
    {
        int numberOfSquareIntegersInTheRange = 0;
        int i = a;

        while (i <= b)
        {
            if (Math.Sqrt(i) % 1 == 0)
            {
                i = (int)Math.Pow(Math.Sqrt(i) + 1, 2);
                numberOfSquareIntegersInTheRange++;
            }
            else
                i++;
        }
        return numberOfSquareIntegersInTheRange;
    }
}
