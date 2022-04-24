namespace Solutions;

public class LibraryFine
{
    /// <param name="d1"> int d1: returned date day </param>
    /// <param name="m1"> int m1: returned date month</param>
    /// <param name="y1"> int y1: returned date year</param>
    /// <param name="d2"> int d2: due date day</param>
    /// <param name="m2"> int m2: due date month</param>
    /// <param name="y2"> int y2: due date year</param>
    /// <returns> int: the amount of the fine or if there is none </returns>
    public static int Run(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        int result = 0;
        int dailyHackos = 15;
        int monthlyHackos = 500;
        int yearlyHackos = 10000;

        DateTime returnedDate = new DateTime(y1, m1, d1);
        DateTime dueDate = new DateTime(y2, m2, d2);

        if (returnedDate < dueDate)
            return 0;

        int dailyTotalHackos = (d1 - d2) * dailyHackos;
        int monthlyTotalHackos = (m1 - m2) * monthlyHackos;
        int yearlyTotalHackos = (y1 - y2) * yearlyHackos;

        if (yearlyTotalHackos > 0)
            result = yearlyTotalHackos;
        else if (monthlyTotalHackos > 0)
            result = monthlyTotalHackos;
        else
            result = dailyTotalHackos;

        return result;
    }
}
