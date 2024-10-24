namespace Strings.Solutions;

public class StringConstruction
{
    public static int Run(string s)
    {
        List<char> result = new();

        foreach (var character in s)
        {
            if (!result.Any(x => x == character))
                result.Add(character);
        }

        return result.Count;
    }
}