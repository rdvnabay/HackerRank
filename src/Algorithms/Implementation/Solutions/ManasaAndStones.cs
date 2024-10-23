namespace Implementation.Solutions;

public class ManasaAndStones
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n">the number of non-zero stones</param>
    /// <param name="a">one possible integer difference</param>
    /// <param name="b">another possible integer difference</param>
    /// <returns></returns>
    public static List<int> Run(int n, int a, int b)
    {
        HashSet<int> result = new();
        int minValue = Math.Min(a, b);
        int maxValue = Math.Max(a, b);

        for (int i = 0, j = n - 1; i < n && j >= 0; i++, j--)
        {
            result.Add((maxValue * i) + (minValue * j));
        }

        return result.ToList();
    }
}