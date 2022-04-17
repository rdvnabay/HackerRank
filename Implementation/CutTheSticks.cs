namespace Implementation;

public class CutTheSticks
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"> the lengths of each stick </param>
    /// <returns> the number of sticks after each iteration </returns>
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
