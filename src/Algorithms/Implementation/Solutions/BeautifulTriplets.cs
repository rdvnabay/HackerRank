namespace Implementation.Solutions;

public class BeautifulTriplets
{
    /// <param name="d"> int d: the value to match </param>
    /// <param name="arr"> int arr[n]: the sequence, sorted ascending </param>
    /// <returns> int: the number of beautiful triplets </returns>
    public static int Run(int d, List<int> arr)
    {
        int numberOfBeautifulTriplets = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            int value = arr[i] + d;
            int index = arr.IndexOf(value);

            if (index != -1)
            {
                value = arr[index] + d;
                index = arr.IndexOf(value);

                if (index != -1)
                    numberOfBeautifulTriplets++;
                else
                    continue;
            }
            else
                continue;
        }

        return numberOfBeautifulTriplets;
    }
}
