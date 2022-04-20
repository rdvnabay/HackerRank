namespace Implementation;

public class SequenceEquation
{
    /// <param name="p"> int p[n]: an array of integers </param>
    /// <returns> int[n]: the values of y for all x in the arithmetic sequence 1 to n </returns>
    public static List<int> Run(List<int> p)
    {
        List<int> list = new();

        for (int i = 1; i <= p.Count; i++)
        {
            int firstSequence = p.IndexOf(i) + 1;
            int secondSequence = p.IndexOf(firstSequence) + 1;
            list.Add(secondSequence);
        }

        return list;
    }
}