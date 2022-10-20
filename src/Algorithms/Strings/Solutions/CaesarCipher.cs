using System.Text;
namespace Strings.Solutions;

public class CaesarCipher
{
    public static string Run(string s, int k)
    {
        StringBuilder stringBuilder = new();
        int alphabetLetterCount = 26;

        foreach (char character in s)
        {
            if (!char.IsLetter(character))
                stringBuilder.Append(character);

            else
            {
                char root = char.IsUpper(character) ? 'A' : 'a';
                int ascii = (character - root + k) % alphabetLetterCount + root;
                stringBuilder.Append((char)ascii);    
            }
        }

        return stringBuilder.ToString();
    }
}
