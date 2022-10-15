namespace Implementation.Solutions;

public class ChocolateFeast
{
    /// <param name="n"> int n: Bobby's initial amount of money </param>
    /// <param name="c"> int c: the cost of a chocolate bar </param>
    /// <param name="m"> int m: the number of wrappers he can turn in for a free bar </param>
    /// <returns> int: the number of chocolates Bobby can eat after taking full advantage of the promotion</returns>
    public static int Run(int n, int c, int m)
    {
        int numberOfChocolatesEaten = n / c;
        int promotion = numberOfChocolatesEaten;

        while (promotion >= m)
        {
            numberOfChocolatesEaten += promotion / m;
            int remainder = promotion % m;
            promotion = (promotion / m) + remainder;
        }

        return numberOfChocolatesEaten;
    }
}
