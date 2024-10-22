namespace Implementation.Solutions;

public class AppendAndDelete
{
    /// <param name="s"> string s: the initial string </param>
    /// <param name="t"> string t: the desired string </param>
    /// <param name="k"> int k: the exact number of operations that must be performed </param>
    /// <returns> string: either Yes or No </returns>
    public static string Run(string s, string t, int k)
    {
        int commonLetterCount = 0;
        for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
        {
            if (s[i] == t[i])
                commonLetterCount++;
            else
                break;
        }

        int remainingLetterCount = (s.Length - commonLetterCount) + (t.Length - commonLetterCount);
        return remainingLetterCount <= k && (k - remainingLetterCount) % 2 == 0 || k >= s.Length + t.Length ? "Yes" : "No";
    }
}