namespace Implementation;

public class CatsAndAMouse
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="x">Cat A: 1</param>
    /// <param name="y">Cat B: 2</param>
    /// <param name="z">Mouse: 3</param>
    /// <returns> Cat B</returns>
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

