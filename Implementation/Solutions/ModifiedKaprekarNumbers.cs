namespace Implementation.Solutions;

public class ModifiedKaprekarNumbers
{
    /// <param name="p"> int p: the lower limit </param>
    /// <param name="q"> int q: the upper limit </param>
    public static void Run(int p, int q)
    {
        int squareOfNumber = 0;
        for (int i = p; i <= q; i++)
        {
            squareOfNumber = (int)Math.Pow(i, 2);
            if (squareOfNumber == Sum(squareOfNumber))
            {

            }

            //if(i=)
        }
    }

    public static int Sum(int number)
    {
        int total = 0;
        foreach (char item in number.ToString())
        {
            total += int.Parse(item.ToString());
        }
        return total;
    }
}
