namespace Sorting.Solutions;

public class IntroToTutorialChallenges
{
    /// <param name="V">a sorted array of integers </param>
    /// <param name="arr">an integer to search for </param>
    /// <returns>the index of in V arr</returns>
    public static int Run(int V, List<int> arr)
    {
        return arr.FindIndex(x => x == V);
    }
}