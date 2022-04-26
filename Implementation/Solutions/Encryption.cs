namespace Implementation.Solutions;

public class Encryption
{
    /// <param name="s"> string s: a string to encrypt </param>
    /// <returns> string: the encrypted string </returns>
    public static string Run(string s)
    {
        string encrypted = "";
        (int row, int column) = RangeStartEnd(s);

        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < row; j++)
            {
                int index = j * column + i;
                if (index < s.Length)
                    encrypted += s[index];
            }

            encrypted += " ";
        }

        return encrypted;
    }

    public static (int, int) RangeStartEnd(string s)
    {
        int row = (int)Math.Floor(Math.Sqrt(s.Length));
        int column = row + 1;
        var result = Math.Pow(row, 2);

        if (s.Length == result)
            column = row;
        else
        {
            result = row * column;
            if (result != s.Length)
                row += 1;
        }
        return (row, column);
    }
}