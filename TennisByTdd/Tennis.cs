namespace TennisByTdd
{
    public class Tennis
    {
        private int player1Score;
        private int player2Score;
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

        public void Player2Hit()
        {
            player2Score += 1;
        }

        public string Score()
        {
            if (player1Score == player2Score) 
            {
                if (player1Score >= 3)
                    return "deuce";

                return $"{scoreMap[player1Score]} all";
            }

            return $"{scoreMap[player1Score]} {scoreMap[player2Score]}";
        }
    }
}