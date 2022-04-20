namespace Implementation;

public class TheHurdleRace
{
    /// <param name="k"> the height the character can jump naturally </param>
    /// <param name="height"> the heights of each hurdle </param>
    /// <returns> the minimum number of doses required, always 0 or more</returns>
    public static int Run(int k, List<int> height)
    {
        int maxHeight = height.Max();
        int result = maxHeight - k;

        if (result > 0)
            return result;
        else
            return 0;
    }
}

