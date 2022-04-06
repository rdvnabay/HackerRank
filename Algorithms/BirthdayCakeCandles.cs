namespace Algorithms;

public class BirthdayCakeCandles
{
    //Define: You are in charge of the cake for a child's birthday.
    //You have decided the cake will have one candle for each year of their total age.
    //They will only be able to blow out the tallest of the candles. Count how many candles are tallest. 

    //Solution
    public static int Run(List<int> candles)
    {
        int maxValue = candles.MaxBy(x => x);
        int result = candles.Where(x => x == maxValue).Count();
        return result;
    }
}

