namespace Strings.Solutions;

public class Pangrams
{
    public static string Run(string s)
    {
        HashSet<char> englishAlphabet = new();
        int alphabetLetterCount = 26;

        foreach (var character in s.ToLower())
        {
            if (char.IsLetter(character))
                englishAlphabet.Add(character);
        }

        return englishAlphabet.Count == alphabetLetterCount ? "pangram" : "not pangram";
    }
}
