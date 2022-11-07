namespace Strings.Solutions;

public class MarsExploration
{
    public static int Run(string s)
    {
        int output = 0;

        IEnumerable<string> splitMessages = Enumerable
            .Range(0, s.Length / 3)
            .Select(i => s
            .Substring(i * 3, 3));

        IEnumerable<string> differentMessages = splitMessages.Where(m => m != "SOS");

        foreach (var item in differentMessages)
        {
            if (item[0] != 'S') output++;
            if (item[1] != 'O') output++;
            if (item[2] != 'S') output++;
        }

        return output;
    }
}
