using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterGame
{
    class Cards
    {

        public enum suits
        {
            spades,
            clubs,
            diamonds,
            hearts
        }


        public enum value
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }


        public suits mysuit { get; set; }
        public value myvalue { get; set; }

                            
        



    }
}
