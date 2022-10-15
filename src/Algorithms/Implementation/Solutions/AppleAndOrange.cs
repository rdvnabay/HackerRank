namespace Implementation.Solutions;

public class AppleAndOrange
{
    /// <param name="s"> starting point of Sam's house location </param>
    /// <param name="t"> ending location of Sam's house location </param>
    /// <param name="a"> location of the Apple tree </param>
    /// <param name="b"> location of the Orange tree </param>
    /// <param name="apples"> distances at which each apple falls from the tree </param>
    /// <param name="oranges"> distances at which each orange falls from the tree </param>
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

