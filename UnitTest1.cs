using System.Security.Cryptography.X509Certificates;
using Xunit;
using System.Collections.Generic;

namespace CourseC_sharp_Game
{
    public class UnitTest1
    {
        [Fact]

        public void SumTest()
        {
            Player player1 = new Player();

            var actual = player1.SumOfCards();

            int expected = 0;

            for (var i = 0; i < player1.Hand.Count; i++)
            {
                expected += player1.Hand[i].CardValue;
            }

            Assert.Equal(expected, actual);
        }
    }
}