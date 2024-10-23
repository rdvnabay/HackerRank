namespace Implementation.Solutions;

public class HappyLadybugs
{
    /// <param name="b">the initial positions and colors of the ladybugs </param>
    /// <returns>either YES or NO</returns>
    public static string Run(string b)
    {
        if (b.All(x => x == '_'))
            return "YES";

        var group = b.ToCharArray().GroupBy(x => x).Select(x => new
        {
            Key = x.Key,
            Count = x.Count()
        });

        foreach (var item in group)
        {
            if (item.Key == '_')
                continue;

            if (item.Count < 2)
                return "NO";
        }

        if (!group.Any(x => x.Key == '_'))
        {
            var currentLetter = b[0];
            int counter = 1;

            for (int i = 1; i < b.ToCharArray().Length; i++)
            {
                if (currentLetter == b[i])
                {
                    counter++;
                }
                else
                {
                    if (counter < 2)
                        return "NO";

                    currentLetter = b[i];
                    counter = 1;
                }
            }
        }

        return "YES";
    }
}