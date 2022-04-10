namespace Implementation;

public class BillDivision
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="bill"> [3, 10, 2, 9] </param>
    /// <param name="k"> 1 </param>
    /// <param name="b"> 12 </param>
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

