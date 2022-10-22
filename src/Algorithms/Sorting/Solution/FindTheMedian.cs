namespace Sorting.Solution;

public class FindTheMedian
{
    public static int Run(List<int> arr)
    {
        arr.Sort();
        return arr[arr.Count / 2];
    }
}
