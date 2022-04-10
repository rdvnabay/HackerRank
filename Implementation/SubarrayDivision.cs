namespace Implementation;

public class SubarrayDivision
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"> [1 2 1 3 2] </param>
    /// <param name="d"> 3 </param>
    /// <param name="m"> 2 </param>
    /// <returns></returns>
    /// 
    public static int Run(List<int> s, int d, int m)
    {
        int startRange = 0;
        int endRange = m - 1;
        int counter = 0;
        int total = 0;

        for (int i = 0; i < s.Count; i++)
        {
            total += s[i];
            if (i == endRange)
            {
                if (total == d)
                    counter++;

                startRange++;
                endRange++;
                i = startRange - 1;
                total = 0;           
            }
        }
        return counter;
    }
}
