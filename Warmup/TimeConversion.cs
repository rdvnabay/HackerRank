namespace Warmup;

public class TimeConversion
{
    /// <param name="input"> time in 12 hour format </param>
    /// <returns> the time in 24 hour format </returns>
    public static string Run(string input)
    {
        DateTime date = Convert.ToDateTime(input);
        return date.ToString("HH:mm:ss");
    }
}

