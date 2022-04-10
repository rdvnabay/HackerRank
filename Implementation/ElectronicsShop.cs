namespace Implementation;

public class ElectronicsShop
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="keyboards"> the keyboard prices: [3, 1] </param>
    /// <param name="drives"> the drive prices: [5, 2, 8] </param>
    /// <param name="b">budget:  10 </param>
    /// <returns> the maximum that can be spent, or -1 if it is not possible to buy both items: 9 </returns>
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

