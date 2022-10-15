namespace Warmup.Solutions;

public class Staircase
{
    public static void Run(int n)
    {
        string output = "";
        for (int i = 0; i <= n; i++) 
        {
            for (int j = 0; j < i; j++)
            {
                output += "*";
            }
            Console.WriteLine(output.PadLeft(n-i,' '));
            output = "";
        }

        Console.ReadKey(); 

        //string output = "****";
        //for (int i = 1; i <= n; i++)
        //{
        //    output = output.PadLeft(n - i, ' ');
        //    Console.WriteLine(output);
        //}

        Console.ReadLine();
    }
}
