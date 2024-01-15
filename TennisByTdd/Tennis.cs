
namespace TennisByTdd
{
    public class Tennis
    {
        private int player1Score;

        public void Player1Hit()
        {
            player1Score += 1;
        }

        public string Score()
        {
            if (player1Score == 1) return "fifteen love";

            return "love all";
        }
    }
}