namespace Warmup;

public class MiniMaxSum
{
    /*
     Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
     Then print the respective minimum and maximum values as a single line of two space-separated long integers.

     Example:
     arr = [1,2,3,4,5]
     The minimum sum is 1+2+3+4=10 and 
     the maximum sum is 2+3+4+5=14.
     */
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

