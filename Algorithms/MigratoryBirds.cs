namespace Algorithms;

public class MigratoryBirds
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"> [1, 4, 4, 4, 5, 3] </param>
    /// <returns> 4 </returns>
    public static int Run(List<int> arr)
    {
        //Solution:1 
        Dictionary<int, int> liste = arr
            .GroupBy(x => x) //[1,4,5,3]
            .ToDictionary(x => x.Key, x => x.Count()); // [1,1] [4,3] [5,1] [3,1]

        var maxItem = liste.MaxBy(x => x.Value);
        return maxItem.Key;
    }
}

