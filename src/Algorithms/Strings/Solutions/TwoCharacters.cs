namespace Strings.Solutions;

public class TwoCharacters
{
    public static int Run(string s)
    {
        List<char> charList = new();
        foreach (var character in s)
        {
            if (!charList.Any(x => x == character))
                charList.Add(character);
        }

        List<List<char>> grouping = new();
        int current = 0;
        for (int i = 0; i < charList.Count; i++)
        {
            if (i == charList.Count - 1)
            {
                current++;
                if (current != charList.Count - 1)
                    i = current;
                else
                    break;
            }
            grouping.Add(new List<char> { charList[current], charList[i + 1] });
        }

        var test = grouping[0][0];
        //s.Contains();
        return 0;

        for (int i = 0; i < grouping.Count; i++)
        {
            //s.Contains(grouping[i][0])
            
        }
    }
}
