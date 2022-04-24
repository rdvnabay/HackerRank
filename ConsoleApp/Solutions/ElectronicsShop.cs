namespace Solutions;

public class ElectronicsShop
{
    /// <param name="keyboards"> the keyboard prices </param>
    /// <param name="drives"> the drive prices </param>
    /// <param name="b"> the budget </param>
    /// <returns> the maximum that can be spent, or -1 if it is not possible to buy both items</returns>
    public static int Run(int[] keyboards, int[] drives, int b)
    {
        int currentCost = 0;
        int maxCost = 0;

        for (int i = 0; i < keyboards.Length; i++)
        {
            for (int j = 0; j < drives.Length; j++)
            {
                if (keyboards[i] + drives[j] <= b)
                {
                    currentCost = keyboards[i] + drives[j];

                    if (maxCost < currentCost)
                        maxCost = currentCost;
                }
            }
        }

        return maxCost > 0 ? maxCost : -1;
    }
}

