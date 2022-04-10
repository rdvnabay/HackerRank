namespace Warmup;

public class PlusMinus
{
    /*
     Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
     Print the decimal value of each fraction on a new line with 6 places after the decimal.

     Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.
     */
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

