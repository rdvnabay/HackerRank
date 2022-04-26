namespace Implementation.Solutions;

public class ModifiedKaprekarNumbers
{
    /// <param name="p"> int p: the lower limit </param>
    /// <param name="q"> int q: the upper limit </param>
    public static void Run(int p, int q)
    {
        bool validRange = false;
        long squareOfNumber = 0;

        for (int i = p; i <= q; i++)
        {
            squareOfNumber = (long)Math.Pow(i, 2);
            if (i == SumOfItsSquare(squareOfNumber))
            {
                validRange = true;
                Console.Write(i + " ");
            }          
        }

        if (!validRange)
            Console.WriteLine("INVALID RANGE");
    }

    private static int SumOfItsSquare(long number)
    {
        int total = 0;
        int index = 0;
        string temp = "";

        int cutInHalf = number.ToString().Length == 1
            ? 1
            : number.ToString().Length / 2;

        foreach (char item in number.ToString())
        {
            temp += item.ToString();
            index++;

            if (index == cutInHalf)
            {
                total += int.Parse(temp);
                temp = "";
            }
        }

        return temp == ""
            ? total
            : total += int.Parse(temp);
    }
}
