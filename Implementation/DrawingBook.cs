namespace Implementation;

public class DrawingBook
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"> the number of pages in the book = 6 </param>
    /// <param name="p"> the page number to turn to = 2 </param>
    /// <returns> 1 </returns>
    public static int Run(int n, int p)
    {
        int counter = 1;
        //int startCounter = 0;
        //int endCounter = 0;

        //for (int i = 1; i <= n; i += 2)
        //{
        //    if (p > i)
        //        startCounter++;

        //    else if (p <= i)
        //        break;
        //}


        List<List<int>> sayilar = new();


        if (n % 2 == 0)
            n += 1;

        for (int i = 1; i <= n; i += 2)
        {
            if (i == 1)
                sayilar.Add(new List<int> { i });
            else
                sayilar.Add(new List<int> { i - 1, i });
        }

        for (int i = 1; i < sayilar.Count; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (p == sayilar[i][j])
                {
                    sayilar.Reverse();
                    Console.WriteLine("counter " + counter);
                    Console.WriteLine("current " + String.Join(" ", sayilar[i]));
                }
                else
                    counter++;
            }
        }

        return 0;

    }
}

