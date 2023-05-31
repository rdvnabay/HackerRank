namespace Implementation.Solutions;

public class AppendAndDelete
{
    /// <param name="s"> string s: the initial string </param>
    /// <param name="t"> string t: the desired string </param>
    /// <param name="k"> int k: the exact number of operations that must be performed </param>
    /// <returns> string: either Yes or No </returns>
    public static string Run(string s, string t, int k)
    {
        int firstWordDiffCount = s.Length;
        int secondWordDiffCount = t.Length;

        for (int i = 0; i < s.Length; i++)
        {
            if (secondWordDiffCount == 0)
                break;

            if (s[i] != t[i])
                break;

            if (s[i] == t[i])
            {
                firstWordDiffCount--;
                secondWordDiffCount--;
            }
        }

        if (firstWordDiffCount + secondWordDiffCount == 0)
            return "Yes";

        if (firstWordDiffCount + secondWordDiffCount == k)
            return "Yes";

        int diff = firstWordDiffCount - secondWordDiffCount;

        int result = (k - diff) % 2;

        return "No";

        //if (firstWordDiffPart > secondWordDiffPart)
        //    if (firstWordDiffPart - k <= secondWordDiffPart)
        //        return "Yes";

        //if (firstWordDiffPart < secondWordDiffPart)
        //    if (firstWordDiffPart + k >= secondWordDiffPart)
        //        return "Yes";

        //if (secondWordDiffPart == 0 && k >= firstWordDiffPart)
        //    return "Yes";

        //if (firstWordDiffPart + secondWordDiffPart == k)
        //    return "Yes";

        //return "No";
    }
}