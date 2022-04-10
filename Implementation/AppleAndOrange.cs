namespace Implementation;

public class AppleAndOrange
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"> falling start point:7 </param>
    /// <param name="t"> falling end point:11 </param>
    /// <param name="a"> apple current point:5 </param>
    /// <param name="b"> orange current point:15 </param>
    /// <param name="apples"> [-2 2 1] </param>
    /// <param name="oranges">[5 -6]</param>

    public static void Run(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int numberOfApplesFallingToTheGround = 0;
        int numberOfOrangesFallingToTheGround = 0;
        int appleFallingPoint = 0;
        int orangeFallingPoint = 0;

        foreach (var apple in apples)
        {
            appleFallingPoint = a + apple;
            if (appleFallingPoint >= s && appleFallingPoint <= t)
                numberOfApplesFallingToTheGround++;
        }

        foreach (var orange in oranges)
        {
            orangeFallingPoint = b + orange;
            if (orangeFallingPoint >= s && orangeFallingPoint <= t)
                numberOfOrangesFallingToTheGround++;
        }

        Console.WriteLine(numberOfApplesFallingToTheGround);
        Console.WriteLine(numberOfOrangesFallingToTheGround);
    }
}

