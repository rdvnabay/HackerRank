namespace Sorting.Solutions;

public class CountingSort1
{
    /// <param name="arr">an array of integers </param>
    /// <returns>a frequency array</returns>
    public static List<int> Run(List<int> arr)
    {
        List<int> result = new();
        foreach (var number in Enumerable.Range(0, 100))
        {
            if (!arr.Any(x => x == number))
            {
                result.Add(0);
                continue;
            }

            var count = arr.Count(x => x == number);
            result.Add(count);
        }

        return result;
    }
}