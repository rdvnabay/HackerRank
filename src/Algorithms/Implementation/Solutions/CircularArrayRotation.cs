namespace Implementation.Solutions;

public class CircularArrayRotation
{
    /// <param name="a"> int a[n]: the array to rotate </param>
    /// <param name="k"> int k: the rotation count </param>
    /// <param name="queries"> int queries[1]: the indices to report </param>
    /// <returns> int[q]: the values in the rotated as requested in m </returns>
    public static List<int> Run(List<int> a, int k, List<int> queries)
    {
        k = k % a.Count;

        List<int> result = new List<int>(queries.Count);

        foreach (int query in queries)
        {
            int newIndex = (query - k + a.Count) % a.Count;
            result.Add(a[newIndex]);
        }

        return result;
    }
}
