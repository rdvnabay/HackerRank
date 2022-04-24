namespace Solutions;

public class CutTheSticks
{
    /// <param name="arr"> int arr[n]: the lengths of each stick </param>
    /// <returns> int[]: the number of sticks after each iteration </returns>
    public static List<int> Run(List<int> arr)
    {
        List<int> numberOfSticksAfterEachIteration = new List<int>();

        while (arr.Count > 0)
        {
            int minValue = arr.Min();
            numberOfSticksAfterEachIteration.Add(arr.Count);

            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] -= minValue;
                if (arr[i] <= 0)
                {
                    arr.Remove(arr[i]);
                    i--;
                }
            }
        }

        return numberOfSticksAfterEachIteration;
    }
}
