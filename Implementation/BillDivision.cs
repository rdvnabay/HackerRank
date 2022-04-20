namespace Implementation;

public class BillDivision
{
    /// <param name="bill"> an array of integers representing the cost of each item ordered </param>
    /// <param name="k"> an integer representing the zero-based index of the item Anna doesn't eat </param>
    /// <param name="b"> the amount of money that Anna contributed to the bill </param>
    public static void Run(List<int> bill, int k, int b)
    {
        int amountPaidTogether = 0;

        for (int i = 0; i < bill.Count; i++)
        {
            if (i == k)
                continue;
            else
                amountPaidTogether += bill[i];
        }

        int result = b - amountPaidTogether / 2;

        if (result == 0)
            Console.WriteLine("Bon Appetit");
        else
            Console.WriteLine(result);
    }
}

