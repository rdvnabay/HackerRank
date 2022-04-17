namespace Implementation;

public class LibraryFine
{
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
