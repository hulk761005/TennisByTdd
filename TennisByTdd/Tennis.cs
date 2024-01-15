namespace TennisByTdd
{
    public class Tennis(string player1Name, string player2Name)
    {
        private int player1Score;
        private int player2Score;
        private readonly string player1Name = player1Name;
        private readonly string player2Name = player2Name;
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

            if (player1Score >= 3 && player2Score >= 3) 
            {
                if (Math.Abs(player1Score - player2Score) == 1)
                {
                    return player1Score > player2Score ? $"{player1Name} adv" : $"{player2Name} adv";
                }
                return player1Score > player2Score ? $"{player1Name} win" : $"{player2Name} win";
            }
            return $"{scoreMap[player1Score]} {scoreMap[player2Score]}";
        }
    }
}