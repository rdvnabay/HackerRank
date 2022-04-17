namespace Implementation;

public class SherlockAndSquares
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"> the lower range boundary </param>
    /// <param name="b"> the upper range boundary </param>
    /// <returns> the number of square integers in the range </returns>
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
