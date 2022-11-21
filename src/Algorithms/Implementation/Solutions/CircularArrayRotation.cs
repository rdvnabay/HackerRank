namespace Implementation.Solutions;

public class CircularArrayRotation
{
    /// <param name="a"> int a[n]: the array to rotate </param>
    /// <param name="k"> int k: the rotation count </param>
    /// <param name="queries"> int queries[1]: the indices to report </param>
    /// <returns> int[q]: the values in the rotated as requested in m </returns>
    public static List<int> Run(List<int> a, int k, List<int> queries)
    {
        List<int> result = new();

        foreach (var rotation in Enumerable.Range(0, k))
        {
            int temp = a.Last();

            for (int i = a.Count - 1; i > 0; i--)
                a[i] = a[i - 1];

            a[0] = temp;
        }

        foreach (var query in queries)
            result.Add(a[query]);

        return result;
    }
}
