namespace Greedy.Solutions;

public class MarkAndToys
{
    public static int Run(List<int> prices, int k)
    {
        prices.Sort();
        int purchased = 0;

        foreach (var price in prices)
        {
            k -= price;
            if (k < 0) return purchased;
            else purchased++;
        }
        return purchased;
    }
}
