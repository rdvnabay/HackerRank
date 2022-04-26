namespace Implementation.Solutions;

public class AngryProfessor
{
    /// <param name="k"> int k: the threshold number of students </param>
    /// <param name="a"> int a[n]: the arrival times of the students </param>
    /// <returns> string: either YES or NO </returns>
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

