namespace Warmup.Solutions;

public class BirthdayCakeCandles
{
    /// <param name="candles" >the candle heights </param>
    /// <returns> the number of candles that are tallest </returns>
    public static int Run(List<int> candles)
    {
        int maxValue = candles.MaxBy(x => x);
        int result = candles.Where(x => x == maxValue).Count();
        return result;
    }
}

