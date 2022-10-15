namespace Strings.Solutions;

public class CamelCase
{
    public static int Run(string s)
    {
        int counter = 1;

        foreach (char character in s)
            if (char.IsUpper(character)) counter++;

        return counter;
    }
}
