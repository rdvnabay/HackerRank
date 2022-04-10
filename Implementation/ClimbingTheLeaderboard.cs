namespace Implementation;

public class ClimbingTheLeaderboard
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ranked"> [100, 100, 50, 40, 40, 20, 10] </param>
    /// <param name="player"> [5, 25, 50, 120] </param>
    /// <returns> [6,4,2,1] </returns>

    public static List<int> Run(List<int> ranked, List<int> player)
    {
        List<int> AliceRank = new();


        var rankingList = ranked
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());

        //var liste = Recursive(rankingList, player, AliceRank);

        return null;
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

