namespace Implementation;

public class DesignerPDFViewer
{
    public static int Run(List<int> h, string word)
    {
        List<char> alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        int maxLetterHeight = 0;
        int wordLength = word.Length;

        foreach (var w in word)
        {
            var index = alphabet.IndexOf(w);

            if (maxLetterHeight < h[index])
                maxLetterHeight = h[index];
        }

        return maxLetterHeight * wordLength;
    }
}

