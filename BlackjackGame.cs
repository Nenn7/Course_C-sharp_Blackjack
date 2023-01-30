using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseC_sharp_Game;
using Xunit.Sdk;

namespace CourseC_sharp_Game
{
    public class BlackjackGame
    {
        CardStack cardstack = new CardStack();

        int blackjack = 21;


        // (Player & dealer tar 2 kort var ifrån stack) 
        Player player1 = new Player();
        Player dealer = new Player();

        public BlackjackGame()
        {

        }

        public void PlayGame()
        {


            // Visar upp dealers kort (och players)
            Console.WriteLine($"Dealerns kort är följande: {string.Join(", ", dealer.Hand)} och summan är: {string.Join(", ", dealer.SumOfCards())}");

            // player.sum & dealer.sum körs och kollar efter blackjack alternativt om någon blivit tjock
            bool run = true;

            while (run)
            {
                if (player1.SumOfCards() == blackjack)
                {
                    Console.WriteLine("Du vann!");
                    break;
                }
                if (player1.SumOfCards() > blackjack)
                {
                    Console.WriteLine($"Du blev tjock, spelet är över. Din summa blev: {string.Join(", ", player1.SumOfCards())}");
                    Console.WriteLine(string.Join(", ", player1.Hand));
                    Console.ReadLine();
                    break;
                }

                if (player1.SumOfCards() < blackjack)
                {
                    Console.WriteLine("Detta är dina kort, Y för att ta nya N för att stanna");
                    Console.WriteLine(string.Join(", ", player1.Hand));
                    Console.WriteLine($"Summan av korten i din hand: {string.Join(", ", player1.SumOfCards())}");
                    string userInput = Console.ReadLine();
                    string input = userInput.ToUpper();

                    switch (input)
                    {
                        case "Y":
                            cardstack.DrawCard(player1);
                            break;
                        case "N":
                            Console.Write($"Du stannade vid: {string.Join(", ", player1.SumOfCards())}");
                            run = false;
                            break;
                        default:
                            Console.WriteLine($"Felaktig inmatning: {input}, skriv Y eller N");
                            break;
                    }
                }
                // } 

                // Ta emot en readline för om playern vill dra kort eller inte 

                // Om dra kort: player.addCard och sen player.Sum, och om player.sum > 21 => player förlorar // kör denna biten igen
                // om spelare väljer detta.

                // If-condition för om player.sum < 21 && dealer.sum < 17 för att avgöra om dealer använder drawcard() eller inte.

            }
        }



    }
}
