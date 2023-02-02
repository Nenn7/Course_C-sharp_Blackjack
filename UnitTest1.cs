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
            //Test f�r att se om SumOfCards faktiskt summerar alla v�rden korrekt baserat p� antalet kort i listan
            Player player1 = new Player();

            var actual = player1.SumOfCards();

            int expected = 0;

            for (var i = 0; i < player1.Hand.Count; i++)
            {
                expected += player1.Hand[i].CardValue;
            }

            Assert.Equal(expected, actual);
        }

        // Testar att DrawCard l�gger till ett nytt kort i spelarens lista av kort 
        [Fact]
        public void DrawCardTest()
        {
            var cardstack = new CardStack();
            var player = new Player();
            var input = "Y";
            int initialHandCount = player.Hand.Count;
            int expectedHandCount = initialHandCount + 1;

            switch (input)
            {
                case "Y":
                    cardstack.DrawCard(player);
                    break;
            }

            int actualHandCount = player.Hand.Count;
            Assert.Equal(expectedHandCount, actualHandCount);
        }
    }
}