namespace Greedy.Solutions;

public class JimAndTheOrders
{
    public static List<int> Run(List<List<int>> orders)
    {
        Dictionary<int, int> dictionary = new();

        for (int i = 0; i < orders.Count; i++)
            dictionary.Add(i + 1, orders[i][0] + orders[i][1]);

        var result = dictionary.OrderBy(x => x.Value).Select(x => x.Key).ToList();

        return result;
    }
}