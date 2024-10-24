namespace Implementation.Solutions;

public class FairRations
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="B"> the numbers of loaves each persons starts with</param>
    /// <returns>the minimum number of loaves required, cast as a string, or 'NO'</returns>
    public static string Run(List<int> B)
    {
        int result = 0;

        var oddNumbersCount = B.Count(x => x % 2 == 1);
        if (oddNumbersCount % 2 == 1)
            return "NO";

        for (int i = 0; i < B.Count - 1; i++)
        {
            var current = B[i];
            var next = B[i + 1];

            if (current % 2 == 1)
            {
                B[i] = current + 1;
                B[i + 1] = next + 1;
                result += 2;
            }
        }

        return result.ToString();
    }
}