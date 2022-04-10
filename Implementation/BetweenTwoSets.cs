namespace Implementation;

public class BetweenTwoSets
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"> [2, 4] </param>
    /// <param name="b"> [16, 32, 96] </param>
    /// <returns> 3 </returns>
    
    public static int Run(List<int> a, List<int> b)
    {
        int firstListMinValue = a.Min();
        int firstListMaxValue = a.Max();
        int secondListMinValue = b.Min();
        List<int> divisionList = new();
  

        var ekok = test(a[0], a[1]);

        for (int i = firstListMaxValue; i <= secondListMinValue; i += firstListMinValue)
        {
            if (i % ekok == 0)
                divisionList.Add(i);     
        }
        return 0;
    }

    public static int Ekok(int num1, int num2)
    {
        int temp = 0;
        while (num2 != 0)
        {
            temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }

    public static int test(int num1, int num2) => (num1 / Ekok(num1, num2) * num2);
}

