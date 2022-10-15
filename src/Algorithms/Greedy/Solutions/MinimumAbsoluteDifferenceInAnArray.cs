namespace Greedy.Solutions;

public class MinimumAbsoluteDifferenceInAnArray
{
    public static int Run(List<int> arr)
    {
        arr.Sort();
        int minDiff = int.MaxValue;

        for (int i = 0; i < arr.Count - 1; i++)
        {
            int currentDiff = Math.Abs(arr[i] - arr[i + 1]);
            minDiff = Math.Min(currentDiff, minDiff);
        }

        return minDiff;
    }
}
