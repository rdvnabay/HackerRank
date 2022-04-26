namespace Implementation.Solutions;

public class SalesByMatch
{
    /// <param name="n"> the number of socks in the pile </param>
    /// <param name="ar"> the colors of each sock </param>
    /// <returns> the number of pairs </returns>
    public static int Run(int n, List<int> ar)
    {
        int result = 0;

        Dictionary<int, int> keyValuePairs = ar
             .GroupBy(x => x)
             .ToDictionary(x => x.Key, x => x.Count());

        foreach (var item in keyValuePairs)
        {
            result += item.Value / 2;
        }

        return result;
    }
}

