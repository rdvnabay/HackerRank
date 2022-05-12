namespace Implementation.Solutions;

public class JumpingOnTheCloudsRevisited
{
    /// <param name="c"> int c[n]: the cloud types along the path </param>
    /// <param name="k"> int k: the length of one jump </param>
    /// <returns> int: the energy level remaining </returns>
    public static int Run(int[] c, int k)
    {
        int energy = 100;

        int i = 0;
        while (true)
        {
            energy = energy - 1 - (2 * c[i]);
            i = (i + k) % c.Length;

            if (i == 0)
                break;
        }
        return energy;
    }
}