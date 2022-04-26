namespace Implementation.Solutions;

public class TaumAndBday
{
    /// <param name="b"> int b: the number of black gifts </param>
    /// <param name="w"> int w: the number of white gifts </param>
    /// <param name="bc"> int bc: the cost of a black gift </param>
    /// <param name="wc"> int wc: the cost of a white gift </param>
    /// <param name="z"> int z: the cost to convert one color gift to the other color </param>
    /// <returns> int: the minimum cost to purchase the gifts </returns>
    public static long Run(int b, int w, int bc, int wc, int z)
    {
        long minBlackCost = (long)b * (long)Math.Min(bc, wc + z);
        long minWhiteCost = (long)w * (long)Math.Min(wc, bc + z);
        return minBlackCost + minWhiteCost;
    }
}
