namespace Implementation;

public class AngryProfessor
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="k"> The professor wants at least (3) students in attendance </param>
    /// <param name="a"> the arrival times of the students </param>
    /// <returns> "NO" </returns>
    public static string Run(int k, List<int> a)
    {
        int onTimeArrivalStudentCount = 0;

        foreach (var item in a)
        {
            if (item <= 0)
                onTimeArrivalStudentCount++;
        }

        return onTimeArrivalStudentCount >= k ? "NO" : "YES";
    }
}

