namespace Algorithms;

public class SalesByMatch
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"> 9 </param>
    /// <param name="ar"> [10, 20, 20, 10, 10, 30, 50, 10, 20] </param>
    /// <returns> 3 </returns>
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

