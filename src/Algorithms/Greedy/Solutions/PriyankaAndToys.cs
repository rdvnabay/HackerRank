namespace Greedy.Solutions;

public class PriyankaAndToys
{
    /// <param name="w">an array of integers that represent the weights of each order to ship</param>
    /// <returns>Return the integer value of the number of containers Priyanka must contract to ship all of the toys. </returns>
    public static int Run(List<int> w)
    {
        var orderedWeights = w.OrderBy(x => x).ToList();

        int groupStart = orderedWeights[0];
        int groupEnd = groupStart + 4;
        int result = 1;

        for (int i = 1; i < orderedWeights.Count; i++)
        {
            if (groupEnd < orderedWeights[i])
            {
                result++;
                groupStart = orderedWeights[i];
                groupEnd = groupStart + 4;
            }
        }

        return result;
    }
}