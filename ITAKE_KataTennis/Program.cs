namespace ITAKE_KataTennis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TennisGame game = new TennisGame();

            while (game.IsOngoing())
            {
                game.PlayBall();
            }
        }
    }
}
