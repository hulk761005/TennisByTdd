
namespace TennisByTdd
{
    public class Tennis
    {
        private int player1Score;
        private readonly Dictionary<int, string> scoreMap = new()
        {
            [0] = "love",
            [1] = "fifteen",
            [2] = "thirty",
            [3] = "forty"
        };

        public void Player1Hit()
        {
            player1Score += 1;
        }

        public string Score()
        {
            if (player1Score > 0) return $"{scoreMap[player1Score]} love";

            return "love all";
        }
    }
}