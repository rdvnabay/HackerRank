namespace Implementation;

public class CountingValleys
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="steps"> 8 </param>
    /// <param name="path"> "UDDDUDUU" </param>
    /// <returns></returns>
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


