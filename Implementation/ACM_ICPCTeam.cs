namespace Implementation;

public class ACM_ICPCTeam
{
    /// <param name="topic"> string topic: a string of binary digits </param>
    /// <returns> int[2]: the maximum topics and the number of teams that know that many topics </returns>
    public static List<int> Run(List<string> topic)  //"10101", "11100", "11010", "00101" 
    {
        Dictionary<string, int> matches = new Dictionary<string, int>();
        int numberOfKnownIssues = 0;

        for (int i = 0; i < topic.Count - 1; i++)
        {
            string currentTeam = topic[i];

            for (int j = i + 1; j < topic.Count; j++)
            {
                string nextTeam = topic[j];

                for (int k = 0; k < currentTeam.Length; k++)
                {
                    if (currentTeam[k] == '1' || nextTeam[k] == '1')
                        numberOfKnownIssues++;
                }

                matches.Add($"{i + 1},{j + 1}", numberOfKnownIssues);
                numberOfKnownIssues = 0;
            }
        }
        var maxNumberOfTopicsKnown = matches.Max(x => x.Value);
        var numberOfTeamsThatKnowTheMaxNumberOfTopics = matches.Where(x => x.Value == maxNumberOfTopicsKnown).Count();

        return new List<int>() { maxNumberOfTopicsKnown, numberOfTeamsThatKnowTheMaxNumberOfTopics };
    }
}
