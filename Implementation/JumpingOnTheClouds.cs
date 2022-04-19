namespace Implementation;

public class JumpingOnTheClouds
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="c"> an array of binary integers </param>
    /// <returns> the minimum number of jumps required </returns>
    public static int Run(List<int> c)
    {
        int numberOfJumps = 0;
        int last = c.Count - 1;
        int step = 0;

        for (int i = 0; i < c.Count; i++)
        {
            if (i != last)
            {
                int next = c[i + 1];

                if (next == 0)
                {
                    step++;
                    numberOfJumps++;
                    if (step == 2)
                    {
                        step = 0;
                        numberOfJumps--;
                    }
                }

                else if (next == 1)
                {
                    i++;
                    step = 0;
                    numberOfJumps++;
                }
            }               
        }

        return numberOfJumps;
    }
}
