using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseC_sharp_Game
{
    internal class Card
    {

        // Card value
        public int CardValue { get; set; }

        // Konstruktor för slumpning av värde (obs alternativt enums för färg/klass senare)

        public Card() { 
            Random random = new Random();

            CardValue = random.Next(1,12);  
        }

        // Override ToString 
        public override string ToString()
        {
            return CardValue.ToString();
        }

    }
}
