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

        // Variabel för värdet av blackjack
        int blackjack = 21;
        
        // Player och dealer skapas och får därmed två kort var
        Player player1 = new Player();
        Player dealer = new Player();

        // Tom konstruktor
        public BlackjackGame()
        {

        }

        public void PlayGame()
        {
            // Skapar en ny cardstack för användning i spelet
            CardStack cardstack = new CardStack();
            
            // Spelinstruktioner
            Console.WriteLine("Välkommen till spelet Blackjack! Ditt mål är att få det totala värdet högre än dealerns, men inte högre än 21.");
            Console.WriteLine("Om dealerns summa är under 17, kommer denne dra kort efter du gjort ditt val. \n");

            bool run = true;
            // En while loop för hantering av spelet som körs så länge run = true, eller varken dealer eller spelare har vunnit
            while (run)
            {

                // Sätter in metodanropen i variabler för ökad läslighet
                int DealerSum = dealer.SumOfCards();
                int PlayerSum = player1.SumOfCards();

                Console.WriteLine($"Dealerns kort är följande: {string.Join(", ", dealer.Hand)}. Summan är: {DealerSum} \n");
                Console.WriteLine($"Detta är dina kort: {string.Join(", ", player1.Hand)}. Summan av dessa är: {PlayerSum}");
                Console.WriteLine("Vill du dra ett kort? Välj \"Y\" för att dra ett kort, \"N\" för att stanna.");

                // Sparande av input från användaren 
                string userInput = Console.ReadLine();
                string input = userInput.ToUpper();

                // En switch för spelarens inputs. Den bryts utifrån valen som spelaren gör
                switch (input)
                {
                    case "Y":
                        cardstack.DrawCard(player1);
                        // Uppdatering av summeringsvariabel
                        PlayerSum = player1.SumOfCards();
                        break;
                    case "N":
                        Console.WriteLine("Du stannade");
                        if (DealerSum < 17 && DealerSum < PlayerSum)
                        {
                            //Så länge dealerns summa är under 17 så ska den kontinuerligt dra nya kort till detta inte längre är fallet
                            while (DealerSum < 17)
                            {
                                cardstack.DrawCard(dealer);
                                DealerSum = dealer.SumOfCards();
                            }
                            Console.WriteLine($"Dealern drar kort: {string.Join(", ", dealer.Hand)}, och dealerns summa är nu: {DealerSum}");
                        }
                        // Kravsättning för hur dealern vinner spelet
                        if (DealerSum > PlayerSum && DealerSum < blackjack || DealerSum == blackjack)
                        {
                            Console.WriteLine($"Dealern vann med summan: {DealerSum}");
                            run = false;
                            break;
                        }
                        if (PlayerSum > DealerSum)
                        {
                            Console.WriteLine("Du vann!");
                            run = false;
                        }

                        break;

                    // Felhantering vid felaktig inmatning från användaren
                     default:
                        Console.WriteLine($"Felaktig inmatning: {input}, skriv Y eller N");
                        break;
                }

                // En samling if-statements för hantering av summor som är över eller lika med 21 (blackjack)
                if (PlayerSum == blackjack)
                {
                    Console.WriteLine("Blackjack! Du vann!");
                    Console.WriteLine($"Korten du vann med: {PlayerSum}");
                    break;
                }

                if (PlayerSum > blackjack)
                {
                    Console.WriteLine($"Du blev tjock, spelet är över. Din summa blev: {PlayerSum}");
                    Console.WriteLine($"Detta var dina kort: {string.Join(", ", player1.Hand)}");
                    break;
                }
                     
                if (DealerSum > blackjack)
                {
                    Console.WriteLine("Dealern blev tjock, du vinner!");
                    break;
                }
                }
        }
    }
}
