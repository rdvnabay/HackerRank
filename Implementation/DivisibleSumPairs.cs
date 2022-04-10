namespace Implementation;

public class DivisibleSumPairs
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"> 6 </param>
    /// <param name="k"> 3 </param>
    /// <param name="ar"> [ 1, 3, 2, 6, 1, 2 ]</param>
    /// <returns> 5 </returns>

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

