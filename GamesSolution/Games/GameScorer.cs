namespace Games;



public class GameScorer
{



    public ScoreReport GenerateScoreReportFor(BowlingGame game)
    {
        // Pre conditions - all of the scores are in the valid ranges and there are no duplicate names.
        // Winners, Losers, Average



        // To Find the winners....
        var players = game.GetPlayers();



        int highScore = 0;
        foreach (var player in players)
        {
            if (player.score > highScore)
            {
                highScore = player.score;
            }
        }
        var winningPlayers = new List<Player>();
        foreach (var player in players)
        {
            if (player.score == highScore)
            {
                winningPlayers.Add(player);
            }
        }



        int lowScore = 301;
        foreach (var player in players)
        {
            if (player.score < lowScore)
            {
                lowScore = player.score;
            }
        }



        var lowScorers = new List<Player>();
        foreach (var player in players)
        {
            if (player.score == lowScore)
            {
                lowScorers.Add(player);
            }
        }



        return new ScoreReport
        {
            Winners = winningPlayers,
            Losers = lowScorers
        };
    }
}