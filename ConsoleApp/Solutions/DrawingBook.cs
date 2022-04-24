namespace Solutions;

public class DrawingBook
{
    /// <param name="n"> the number of pages in the book </param>
    /// <param name="p"> the page number to turn to </param>
    /// <returns> the minimum number of pages to turn </returns>
    public static int Run(int n, int p)
    {
        int pageTurnCount = 0;
        int findStartOfBook = 0;
        int findEndOfBook = 0;

        for (int i = 2; i <= n; i += 2)
        {
            pageTurnCount++;
            int leftPageOfTheBook = i;
            int rightPageOfTheBook = i + 1;

            if (p == leftPageOfTheBook || p == rightPageOfTheBook)
                findStartOfBook = pageTurnCount;

            if (n == leftPageOfTheBook || n == rightPageOfTheBook)
                findEndOfBook = pageTurnCount - findStartOfBook;
        }

        return findStartOfBook < findEndOfBook ? findStartOfBook : findEndOfBook;
    }
}

