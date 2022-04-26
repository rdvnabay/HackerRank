namespace Implementation.Solutions;

public class ClimbingTheLeaderboard
{
    /// <param name="ranked"> the leaderboard scores </param>
    /// <param name="player"> the player's scores </param>
    /// <returns> the player's rank after each new score </returns>
    public static List<int> Run(List<int> ranked, List<int> player)
    {
        List<int> AliceRank = new();


        var rankingList = ranked
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());

        //var liste = Recursive(rankingList, player, AliceRank);

        return AliceRank;
    }

    public static List<int> Recursive(Dictionary<int, int> rankingList, List<int> player, List<int> AliceRank)
    {
        int counter = 0;
        int climbingAttemptCount = 0;
        int lastRank = rankingList.Count + 1;

        foreach (var rank in rankingList)
        {
            if (player.Count > 4)
                break;

            counter++;
            if (player[climbingAttemptCount] >= rank.Key)
            {
                AliceRank.Add(counter);
                break;
            }

            else
                continue;

        }
        Recursive(rankingList, player, AliceRank);
        return AliceRank;
    }
}

