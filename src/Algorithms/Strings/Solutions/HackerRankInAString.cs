namespace Strings.Solutions;

public class HackerRankInAString
{
    /// <param name="s"></param>
    /// <returns>YES or NO</returns>
    public static string Run(string s)
    {
        string originText = "hackerrank";
        List<char> sameCharacters = new();
        int lastIndex = 0;
      
        for (int i = 0; i < originText.Length; i++)
        {
            for (int j = lastIndex; j < s.Length; j++)
            {
                if (originText[i] == s[j])
                {
                    lastIndex = j + 1;
                    sameCharacters.Add(originText[i]);
                    break;
                }
            }
        }

        string output = new string(sameCharacters.ToArray());
        return output == originText ? "YES" : "NO";
    }
}