namespace Implementation;

public class SequenceEquation
{
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