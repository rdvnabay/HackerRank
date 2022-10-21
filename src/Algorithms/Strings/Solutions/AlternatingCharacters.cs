namespace Strings.Solutions;

public class AlternatingCharacters
{
    public static int Run(string s)
    {
        int deletionCount = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
                deletionCount++;
        }

        return deletionCount;
    }
}
