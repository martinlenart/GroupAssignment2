using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
    class DeckOfCards
    {
        const int MaxNrOfCards = 52;
        
        int nrOfCards = 52;
        PlayingCard[] cards = new PlayingCard[MaxNrOfCards];

        public PlayingCard this[int idx]
        {
            get
            {
                return cards[idx];
            }
        }
        /// <summary>
        /// Number of Cards in the deck
        /// </summary>
        public int Count => nrOfCards;

        /// <summary>
        /// Overriden and used by for example Console.WriteLine()
        /// </summary>
        /// <returns>string that represents the complete deck of cards</returns>
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < nrOfCards; i++)
            {
                sRet += cards[i].ToString() + "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle()
        {
            var rnd = new Random();
            int nrOfShuffles = rnd.Next(100, 100000);
            for (int shuffle = 0; shuffle < nrOfShuffles; shuffle++)
            {
                //Swap to random cards with each other
                int loCard = rnd.Next(0, 52);
                int hiCard = rnd.Next(0, 52);

                (cards[loCard], cards[hiCard]) = (cards[hiCard], cards[loCard]);
            }
        }
        /// <summary>
        /// Initialize a fresh deck consisting of 52 cards
        /// </summary>
        public void FreshDeck()
        {
            nrOfCards = 52;
            int cardNr = 0;
            for (PlayingCardColor c = PlayingCardColor.Clubs; c <= PlayingCardColor.Spades; c++)
            {
                for (PlayingCardValue v = PlayingCardValue.Two; v <= PlayingCardValue.Ace; v++)
                {
                    cards[cardNr] = new PlayingCard { Color = c, Value = v };
                    cardNr++;
                }
            }
        }

        public PlayingCard GetTopCard()
        {
            return cards[nrOfCards-- - 1];
        }

        public DeckOfCards()
        {
            FreshDeck();
        }
    }
}
