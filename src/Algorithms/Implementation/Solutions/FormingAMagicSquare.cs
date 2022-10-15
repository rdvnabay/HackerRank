namespace Implementation.Solutions;

public class FormingAMagicSquare
{
    /// <param name="s"> a 3x3 array of integers </param>
    /// <returns> the minimal total cost of converting the input square to a magic square </returns>
    public static int Run(List<List<int>> s)
    {
        List<int> evenNumbers = new() { 2, 4, 6, 8 };
        List<int> oddNumbers = new() { 1, 3, 7, 9 };
        int output = 0;

        if (s[0][0] % 2 == 0)
        {
            output = Math.Abs(s[2][2] - (10 - s[0][0]));
            s[2][2] = 10 - s[0][0];
        }

        for (int i = 0; i < s.Count; i++)
        {
            for (int j = 0; j < s.Count; j++)
            {

            }
        }


        Console.WriteLine("d" + s[2][2]);
        Console.WriteLine("ou" + output);
        Console.ReadKey();
        return 0;
    }
}
