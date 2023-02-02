using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_sharp_Game
{
    internal class Player
    {
        // Lista av Kort
        public List<Card> Hand { get; set; }

        // Konstruktor som tar två kort ifrån korthög och lägger till i spelarens lista av kort.
        public Player()
        {
            Hand = new List<Card>();
            Hand.Add(new Card());
            Hand.Add(new Card());
        }

        //Funktion för att summera spelare och dealers kortvärden
        public int SumOfCards()
        {
            int sum = 0;
            foreach (var card in Hand)
            {
                sum += card.CardValue;
            }
            return sum;
        }
    }
}


