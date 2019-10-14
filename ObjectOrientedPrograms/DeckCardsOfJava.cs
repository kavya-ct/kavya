using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    /// <summary>
    /// DeckCardsOfJava is the class
    /// </summary>
    public class DeckCardsOfJava
    {
        /// <summary>
        /// Decks this instance.
        /// </summary>
       public void Deck()
        {
            String[] SUITS = {
                   "Clubs", "Diamonds", "Hearts", "Spades"
            };

            String[] RANKS = {
            "2", "3", "4", "5", "6", "7", "8", "9", "10",
            "Jack", "Queen", "King", "Ace"
             };

           


        //Initialze Deck
        int n = SUITS.Length * RANKS.Length;
            String[] deck = new String[n];
            for (int i = 0; i < RANKS.Length; i++)
            {
                for (int j = 0; j < SUITS.Length; j++)
                {
                    deck[SUITS.Length * i + j] = RANKS[i] + "of" + SUITS[j];
                }
            }

            //Shuffle

            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                int r = i + (int)(random.Next() * (n - i));
                String temp = deck[r];
                deck[r] = deck[i];
                deck[i] = temp;
            }

            //print Shuffled Deck
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(deck[i]);
            }
        }

    }
}
    

        
       


















