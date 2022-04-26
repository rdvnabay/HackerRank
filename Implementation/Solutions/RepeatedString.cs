namespace Implementation.Solutions;

public class RepeatedString
{
    /// <param name="s"> a string to repeat </param>
    /// <param name="n"> the number of characters to consider </param>
    /// <returns> int: the frequency of a in the substring </returns>
    public static long Run(string s, long n)
    {
        long containingTheLetterA = 0;
        var remainingLettersCount = n % s.Length;

        foreach (char c in s)
        {
            if (c == 'a')
                containingTheLetterA++;
        }

        long result = n / s.Length * containingTheLetterA;

        for (int i = 0; i < remainingLettersCount; i++)
        {
            if (s[i] == 'a')
                result++;
        }

        return result;
    }
}
