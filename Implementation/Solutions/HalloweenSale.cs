namespace Implementation.Solutions;

public class HalloweenSale
{
    /// <param name="p"> int p: the price of the first game </param>
    /// <param name="d"> int d: the discount from the previous game price</param>
    /// <param name="m"> int m: the minimum cost of a game </param>
    /// <param name="s"> int s: the starting budget </param>
    /// <returns> the number of games you can buy </returns>
    public static int Run(int p, int d, int m, int s)
    {
        int numberOfGamesCanBuy = 0;

        if (s < p)
            return numberOfGamesCanBuy;

        while (s >= p)
        {
            s -= p;
            numberOfGamesCanBuy++;
            p -= d;

            if (p < m)
                p = m;
        }

        return numberOfGamesCanBuy;
    }
}
