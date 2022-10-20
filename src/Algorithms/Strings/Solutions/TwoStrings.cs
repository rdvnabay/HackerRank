namespace Strings.Solutions;

public class TwoStrings
{
    public static string Run(string s1, string s2)
    {
        HashSet<char> s1HashSet = new();

        foreach (char character in s1)
            s1HashSet.Add(character);

        foreach (var character in s2)
            if (s1HashSet.Contains(character)) return "YES";

        return "NO";
    }
}
