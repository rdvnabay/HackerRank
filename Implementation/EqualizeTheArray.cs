namespace Implementation;

public class EqualizeTheArray
{
    /// <param name="arr"> an array of integers </param>
    /// <returns> the minimum number of deletions required </returns>
    public static int Run(List<int> arr)
    {
        var mostRepeatedNumber = arr
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count())
            .Max(x => x.Value);

        int minNumberOfDeletionsRequired = arr.Count - mostRepeatedNumber;

        return minNumberOfDeletionsRequired;
    }
}
