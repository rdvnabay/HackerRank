namespace Implementation;

public class TheHurdleRace
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="k"> 4 </param>
    /// <param name="height"> [1 6 3 5 2] </param>
    /// <returns></returns>
    public static int Run(int k, List<int> height)
    {
        int maxHeight = height.Max();
        int result = maxHeight - k;
        if (result > 0)
            return result;
        else
            return 0;
    }
}

