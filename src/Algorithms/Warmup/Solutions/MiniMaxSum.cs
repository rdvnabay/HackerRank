namespace Warmup.Solutions;

public class MiniMaxSum
{
    /// <param name="arr"> an array of 5 integers </param>
    public static void Run(List<int> arr)
    {
        long minResult = 0;
        long maxResult = 0;
        int totalArrCapacity = arr.Count - 1;

        foreach (var currentValue in arr)
        {
            minResult += currentValue;
            maxResult += currentValue;

            if (arr.Min() == arr.Max())
            {
                minResult = arr.Min() * totalArrCapacity;
                maxResult = arr.Max() * totalArrCapacity;
                break;
            }

            if (currentValue == arr.Min())
                maxResult -= currentValue;

            else if (currentValue == arr.Max())
                minResult -= currentValue;

        }
        Console.WriteLine(minResult + " " + maxResult);
    }
}

