namespace ITAKE_KataTennis
{
    using System;
    using System.Linq;

    public class TennisGame
    {
        ScoreEnum[] scores = new ScoreEnum[2] { ScoreEnum.Score0, ScoreEnum.Score0 };

        public bool IsOngoing()
        {
            return scores.All(s => s != ScoreEnum.Won);
        }

        public void PlayBall()
        {
            AdjustScore(GetWinner());
        }

        private void AdjustScore(int playerNumber)
        {
            scores[playerNumber] = this.GetNextScore(scores[playerNumber]);
        }

        private int GetWinner()
        {
            var random = new Random();
            return random.Next(2);
        }

        private ScoreEnum GetNextScore(ScoreEnum currentScore)
        {
            return Enum.GetValues(typeof(ScoreEnum)).Cast<ScoreEnum>().First(e => (int)e > (int)currentScore);
        }

        private ScoreEnum GetPreviousScore(ScoreEnum currentScore)
        {
            return Enum.GetValues(typeof(ScoreEnum)).Cast<ScoreEnum>()
                .Where(e => (int)e > (int)currentScore)
                .OrderBy(e => e).First();
        }
    }
}