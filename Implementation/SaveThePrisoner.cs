namespace Implementation;

public class SaveThePrisoner
{
    /// <param name="n"> int n: the number of prisoners </param>
    /// <param name="m"> int m: the number of sweets </param>
    /// <param name="s"> int s: the chair number to begin passing out sweets from </param>
    /// <returns> int: the chair number of the prisoner to warn </returns>
    public static int Run(int n, int m, int s)
    {
        int currentPrisoner = 0;
        for (int i = s; i <= n; i++)
        {
            if (m == 0)
            {
                currentPrisoner = i - 1;
                break;
            }
            else
            {
                if (i == n)
                    i = 0;

                m--;
            }
        }

        return currentPrisoner;
    }
}