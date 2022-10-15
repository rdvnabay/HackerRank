namespace Implementation.Solutions;

public class NonDivisibleSubset
{
    /// <param name="k"> int S[n]: an array of integers </param>
    /// <param name="s"> int k: the divisor </param>
    /// <returns> int: the length of the longest subset of meeting the criteria </returns>
    public static int Run(int k, List<int> s)
    {
        HashSet<int> criteriaList = new HashSet<int>();

        for (int i = 0; i < s.Count - 1; i++)
        {
            for (int j = i + 1; j < s.Count; j++)
            {
                int total = s[i] + s[j];
                if (total % k != 0)
                {
                    criteriaList.Add(s[i]);
                    criteriaList.Add(s[j]);
                }
            }
        }

        return criteriaList.Count;
    }
}