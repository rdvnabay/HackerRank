namespace Implementation;

public class BetweenTwoSets
{
    /// <param name="a"> an array of integers  </param>
    /// <param name="b"> an array of integers </param>
    /// <returns> the number of integers that are between the sets </returns>
    public static int Run(List<int> a, List<int> b)
    {
        int divisionCounter = 0;
        bool divisible = false;
        int secondListMinValue = b.Min();
        int leastCommonMultiple = GetLeastCommonMultiple(a, a.Max());

        if (leastCommonMultiple == 0)
            return 0;

        for (int i = leastCommonMultiple; i <= secondListMinValue; i += leastCommonMultiple)
        {
            for (int j = 0; j < b.Count; j++)
            {
                if (b[j] % i == 0)
                    divisible = true;
                else
                {
                    divisible = false;
                    break;
                }
            }

            if (divisible)
            {
                divisionCounter++;
                divisible = false;
            }
        }
        return divisionCounter;
    }


    public static int GetLeastCommonMultiple(List<int> numbers, int currentMaxValue)
    {
        int defaultMaxNumber = numbers.Max();
        bool result = false;

        foreach (var number in numbers)
        {
            if (currentMaxValue % number == 0)
                result = true;

            else
            {
                result = false;
                break;
            }
        }

        try
        {
            if (!result)
            {
                checked
                {
                    currentMaxValue += defaultMaxNumber;
                    GetLeastCommonMultiple(numbers, currentMaxValue);
                }
            }
        }
        catch (Exception)
        {
            return 0;
        }

        return currentMaxValue;
    }
}



