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

        [Test]
        public void Player1_Hit_The_Point_Twice()
        {
            var tennis = new Tennis();
            Player1Hit(tennis, 2);
            var score = tennis.Score();

            score.Should().Be("thirty love");
        }

        [Test]
        public void Player1_Hit_The_Point_Three_Times()
        {
            var tennis = new Tennis();
            Player1Hit(tennis, 3);
            var score = tennis.Score();

            score.Should().Be("forty love");
        }

        [Test]
        public void Player2_Hit_The_Point()
        {
            var tennis = new Tennis();
            tennis.Player2Hit();
            var score = tennis.Score();

            score.Should().Be("love fifteen");
        }

        [Test]
        public void Player2_Hit_The_Point_Twice()
        {
            var tennis = new Tennis();
            var numberOfTimes = 2;
            Player2Hit(tennis, numberOfTimes);
            var score = tennis.Score();

            score.Should().Be("love thirty");   
        }

        [Test]
        public void Player1_And_Player2_Fifteen_All() 
        {
            var tennis = new Tennis();
            tennis.Player1Hit();
            tennis.Player2Hit();
            var score = tennis.Score();

            score.Should().Be("fifteen all");
        }

        [Test]
        public void Player1_And_Player2_Thirty_All()
        {
            var tennis = new Tennis();
            var numberOfTime = 2;

            Player1Hit(tennis, numberOfTime);
            Player2Hit(tennis, numberOfTime);
            var score = tennis.Score();

            score.Should().Be("thirty all");
        }

        private static void Player1Hit(Tennis tennis, int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                tennis.Player1Hit();
            }
        }
        private static void Player2Hit(Tennis tennis, int numberOfTimes)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                tennis.Player2Hit();
            }
        }
    }
}