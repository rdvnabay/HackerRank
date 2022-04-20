namespace Implementation;

public class MigratoryBirds
{
    /// <param name="arr"> the types of birds sighted </param>
    /// <returns> the lowest type id of the most frequently sighted birds </returns>
    public static int Run(List<int> arr)
    {
        Dictionary<int, int> keyValuePairs = arr
            .GroupBy(x => x) //[1,4,5,3]
            .OrderBy(x => x.Key) // [1,3,4,5]
            .ToDictionary(x => x.Key, x => x.Count()); // [1,1] [3,1] [4,3] [5,1] 

        int maxValue = keyValuePairs.Max(x => x.Value); //3

        KeyValuePair<int, int> maxKeyValuePair = keyValuePairs.Where(x => x.Value == maxValue).First(); // [4,3]
        return maxKeyValuePair.Key;
    }
}

