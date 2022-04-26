namespace Implementation.Solutions;

public class BiggerIsGreater
{
    /// <param name="w"> string w: a word </param>
    /// <returns> string: the smallest lexicographically higher string possible or no answer </returns>
    public static string Run(string w)
    {
        var word = w.ToArray();
        int counter = 0;
        for (int currentLetter = word.Length - 1; currentLetter >= 0; currentLetter--)
        {
            for (int previousLetter = currentLetter - 1; previousLetter >= 0; previousLetter--)
            {
                if (word[currentLetter] > word[previousLetter])
                {
                    char temp = word[previousLetter];
                    word[previousLetter] = word[currentLetter];

                    while (previousLetter + 1 < word.Length)
                    {
                        word[3]=word[previousLetter + 1];
                        word[previousLetter + 1] = temp;

                    }

                    while (counter > 0)
                    {
                        word[previousLetter + 1] = word[currentLetter + 1];
                    }
                }
            }
            counter++;

            //else
            //    return "no answer";

        }
        return word.ToString();
    }
}
