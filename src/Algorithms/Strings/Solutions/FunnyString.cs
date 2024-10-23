namespace Strings.Solutions;

public class FunnyString
{
    public static string Run(string s)
    {
        string reversed = new string(s.Reverse().ToArray());
        for (int i = s.Length - 1; i > 0; i--)
        {
            var result1 = Math.Abs(s[i] - s[i - 1]);
            var result2 = Math.Abs(reversed[i] - reversed[i - 1]);

            if (result1 != result2)
                return "Not Funny";
        }

        return "Funny";
    }
}