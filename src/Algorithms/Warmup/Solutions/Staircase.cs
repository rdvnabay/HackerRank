namespace Warmup.Solutions;

public class Staircase
{
    public static void Run(int n)
    {
        string result = string.Empty;

        for (int i = 1, j = n - 1; i <= n && j >= 0; i++, j--)
        {
            result = new string(' ', j) + new string('#', i);
            Console.WriteLine(result);
        }
    }
}