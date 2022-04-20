namespace Implementation;

public class CatsAndAMouse
{
    /// <param name="x"> Cat A's position </param>
    /// <param name="y"> Cat B's position </param>
    /// <param name="z"> Mouse C's position </param>
    /// <returns> Either 'Cat A', 'Cat B', or 'Mouse C' </returns>
    public static string Run(int x, int y, int z)
    {
        int catA = Math.Abs(z - x);
        int catB = Math.Abs(z - y);

        if (catA < catB)
            return "Cat A";
        else if (catB < catA)
            return "Cat B";
        else
            return "Mouse C";
    }
}

