namespace Implementation.Solutions;

public class ServiceLane
{
    /// <param name="n"> int n: the size of the width array </param>
    /// <param name="width"> int cases[t][2]: each element contains the starting and ending </param>
    /// <param name="cases"> indices for a segment to consider, inclusive </param>
    /// <returns> int[t]: the maximum width vehicle that can pass through each segment of the service lane described </returns>

    //NOTE: List<int> width => Since this parameter was forgotten to be passed by the hackerrank team, I added it myself.
    public static List<int> Run(int n, List<int> width, List<List<int>> cases)
    {
        List<int> output = new List<int>();

        for (int i = 0; i < cases.Count; i++)
        {
            int minValue = width[cases[i][0]];
            int start = cases[i][0];
            int end = cases[i][1];

            for (int j = start; j <= end; j++)
            {
                if (minValue > width[j])
                    minValue = width[j];
            }
            output.Add(minValue);
        }
        return output;
    }
}
