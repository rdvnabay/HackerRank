namespace Solutions;

public class DivisibleSumPairs
{
    /// <param name="n"> the length of array ar </param>
    /// <param name="k"> the integer divisor </param>
    /// <param name="ar"> an array of integers </param>
    /// <returns> the number of pairs </returns>
    public static int Run(int n, int k, List<int> ar)
    {
        int currentValue = 0;
        int counter = 0;
        int index = 0;

        currentValue = ar[index];

        for (int i = 1; i < ar.Count; i++)
        {
            currentValue += ar[i];

            if (currentValue % k == 0)
                counter++;

            currentValue = ar[index];

            if (i == n - 1)
            {
                index++;
                i = index;
                currentValue = ar[index];
            }
        }

        return counter;
    }
}

