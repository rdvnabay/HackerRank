namespace Warmup.Solutions;

public class PlusMinus
{
    /// <param name="arr"> an array of integers </param>
    public static void Run(List<int> arr)
    {
        int positiveNumberCount = 0;
        int negativeNumberCount = 0;
        int zeroNumberCount = 0;

        foreach (var el in arr)
        {
            if (el > 0)
                positiveNumberCount++;
            else if (el < 0)
                negativeNumberCount++;
            else
                zeroNumberCount++;
        }

        Console.WriteLine((double)positiveNumberCount / (double)arr.Count);
        Console.WriteLine((double)negativeNumberCount / (double)arr.Count);
        Console.WriteLine((double)zeroNumberCount / (double)arr.Count);
    }
}

