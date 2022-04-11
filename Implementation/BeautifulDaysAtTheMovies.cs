namespace Implementation;

public class BeautifulDaysAtTheMovies
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="i"> 20 </param>
    /// <param name="j"> 23 </param>
    /// <param name="k"> 6 </param>
    /// <returns> 2 </returns>
    public static int Run(int i, int j, int k)
    {
        int reminder, reverse = 0;

        for (int number = i; number <= j; number++)
        {
            Console.WriteLine("number " + number);
            //while (number > 0)
            //{
            //    reminder = number % 10;
            //    reverse = (reverse * 10) + reminder;
            //    number = number / 10;
            //}
            //Console.WriteLine("rev " + reverse);
        }
        return 0;
    }
}

