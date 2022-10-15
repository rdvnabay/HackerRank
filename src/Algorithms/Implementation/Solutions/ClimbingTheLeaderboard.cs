namespace Implementation.Solutions;

public class ClimbingTheLeaderboard
{
    /// <param name="ranked"> the leaderboard scores </param>
    /// <param name="player"> the player's scores </param>
    /// <returns> the player's rank after each new score </returns>
    public static List<int> Run(List<int> ranked, List<int> player)
    {
        var playerRank = new List<int>();
        ranked = new HashSet<int>(ranked).OrderBy(x => x).ToList();

        int i = 0;
        foreach (var playerPoint in player)
        {
            while (i < ranked.Count && playerPoint >= ranked[i])
                i++;

            playerRank.Add(ranked.Count - i + 1);
        }

        return playerRank;
    }
}

