namespace Solutions;

public class SaveThePrisoner
{
    /// <param name="n"> int n: the number of prisoners </param>
    /// <param name="m"> int m: the number of sweets </param>
    /// <param name="s"> int s: the chair number to begin passing out sweets from </param>
    /// <returns> int: the chair number of the prisoner to warn </returns>
    public static int Run(int n, int m, int s)
    {
        return ((s - 1 + m - 1) % n) + 1;
    }
}