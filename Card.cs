using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_sharp_Game
{
    internal class Card
    {

        // Slumpat värde av kort

        public int CardValue { get; set; }

        // Konstruktor för slumpning av värde

        public Card() { 
            Random random = new Random();

            CardValue = random.Next(1,11);  
        }

        // Override av ToString för att kunna visa upp kortvärde
        public override string ToString()
        {
            return CardValue.ToString();
        }

    }
}
