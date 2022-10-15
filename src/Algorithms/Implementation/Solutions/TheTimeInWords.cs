namespace Implementation.Solutions;

public class TheTimeInWords
{
    /// <param name="h"> int h: the hour of the day </param>
    /// <param name="m"> int m: the minutes after the hour </param>
    /// <returns> string: a time string as described </returns>
    public static string Run(int h, int m)
    {
        string output = "";
        List<string> strHour = new List<string>() { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };
        List<string> strMinute = new List<string>() { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                                                        "eleven","twelve","thirteen","fourteen","quarter","sixteen","seventeen","eighteen","nineteen","twenty",
                                                        "twenty one","twenty two","twenty three","twenty four","twenty five","twenty six","twenty seven","twenty eight","twenty nine","half"};

        if (m >= 0 && m <= 30)
        {
            if (m == 0)
                output = $"{strHour[h]} o' clock";

            else if (m == 1)
                output = $"{strMinute[m]} minute past {strHour[h]}";

            else if (m == 15 || m == 30)
                output = $"{strMinute[m]} past {strHour[h]}";

            else
                output = $"{strMinute[m]} minutes past {strHour[h]}";
        }

        else if (m > 30 && m < 60)
        {
            h += 1;
            m %= 30;
            strMinute.Reverse();

            if (m == 15)
                output = $"{strMinute[m]} to {strHour[h]}";
            else
                output = $"{strMinute[m]} minutes to {strHour[h]}";
        }

        return output;
    }
}
