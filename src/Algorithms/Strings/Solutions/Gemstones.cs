namespace Strings.Solutions;

public class Gemstones
{
    /// <param name="arr">an array of strings </param>
    /// <returns></returns>
    public static int Run(List<string> arr)
    {
        int result = 0;
        List<char> letters = new()
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        foreach (var letter in letters)
            if (arr.All(s => s.Contains(letter)))
                result++;

        return result;
    }
}