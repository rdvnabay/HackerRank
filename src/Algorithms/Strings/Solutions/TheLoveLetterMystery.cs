namespace Strings.Solutions;

public class TheLoveLetterMystery
{
    /// <param name="s">the text of the letter </param>
    /// <returns>the minimum number of operations </returns>
    public static int Run(string s)
    {
        int start = 0;
        int end = s.ToCharArray().Length - 1;
        int result = 0;

        for (int i = start; i <= end; i++)
        {
            result += Math.Abs(s[start] - s[end]);
            start++;
            end--;

            if (start == end)
                break;
        }

        return result;
    }
}