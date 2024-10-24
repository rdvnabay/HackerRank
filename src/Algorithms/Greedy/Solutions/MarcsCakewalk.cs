namespace Greedy.Solutions;

public class MarcsCakewalk
{
    /// <param name="calorie">the calorie counts for each cupcake</param>
    /// <returns>the minimum miles necessary</returns>
    public static long Run(List<int> calorie)
    {
        var orderedCalorie = calorie.OrderByDescending(x => x).ToList();
        long result = 0;

        foreach (var index in Enumerable.Range(0, calorie.Count))
        {
            long calorieValue = Convert.ToInt64(orderedCalorie[index]);
            result += calorieValue * Convert.ToInt64(Math.Pow(2, index));
        }

        return result;
    }
}