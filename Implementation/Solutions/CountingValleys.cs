namespace Solutions;

public class CountingValleys
{
    /// <param name="steps"> the number of steps on the hike </param>
    /// <param name="path"> a string describing the path </param>
    /// <returns> the number of valleys traversed </returns>
    public static int Run(int steps, string path)
    {
        var hikeCoordinates = new List<int>();
        int coordinate = 0;
        int numberOfValleysTraversed = 0;

        foreach (var p in path)
        {
            if (p == 'U')
                coordinate++;

            else if (p == 'D')
                coordinate--;

            hikeCoordinates.Add(coordinate);
        }

        for (int i = 0; i < hikeCoordinates.Count; i++)
        {
            if (i > 0)
            {
                int prev = hikeCoordinates[i - 1];

                if (hikeCoordinates[i] == 0)
                    if (prev == -1)
                        numberOfValleysTraversed++;
            }
        }

        return numberOfValleysTraversed;
    }
}


