namespace Implementation;

public class CountingValleys
{
    /// <param name="steps"> the number of steps on the hike </param>
    /// <param name="path"> a string describing the path </param>
    /// <returns> the number of valleys traversed </returns>
    public static int Run(int steps, string path)
    {
        int first = path[0];
        int last = path[steps - 1];

        int counter = 0;
        int startPoint = path[0];
        int i = 0;
        do
        {
            i++;
            counter++;
        }
        while (startPoint == path[i]);

        if (first != last)
            counter--;

        Console.WriteLine("c" + counter);
        return counter;
    }
}


