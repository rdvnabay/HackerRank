namespace Implementation.Solutions;

public class MinimumDistances
{
    /// <param name="a"> int a[n]: an array of integers </param>
    /// <returns> int: the minimum distance found or -1 if there are no matching elements </returns>
    public static int Run(List<int> a)
    {
        List<int> matchingRecords = new List<int>();

        for (int i = 0; i < a.Count; i++)
        {
            int index = a.IndexOf(a[i], i + 1);

            if (index != -1)
            {
                int diff = index - i;
                matchingRecords.Add(diff);
            }
        }

        return matchingRecords.Count > 0 ? matchingRecords.Min() : -1;
    }
}
