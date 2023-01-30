using CourseC_sharp_Game;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_sharp_Game
{

    internal class CardStack
    {
        // Stack av 52 Kortobjekt
        private readonly Stack<Card> Stack;

        // Konstruktor 
        public CardStack()
        {
            Stack = new Stack<Card>();
            for (var i = 0; i < 52; i++)
            {
                Stack.Push(new Card());
            }
        }

        // Metod för att ta ett kort
        public void DrawCard(Player player)
        {
            player.Hand.Add(Stack.Pop());
        }
    }

}
