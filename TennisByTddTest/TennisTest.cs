using FluentAssertions;
using TennisByTdd;

namespace TennisByTddTest
{
    public class TennisTest
    {
        [Test]
        public void Player1_And_Player2_Love_All()
        {
            var tennis = new Tennis();
            var score = tennis.Score();
            score.Should().Be("love all");
        }

        [Test]
        public void Player1_Hit_The_Point() 
        {
            var tennis = new Tennis();
            tennis.Player1Hit();
            var score = tennis.Score();

            score.Should().Be("fifteen love");
        }
    }
}