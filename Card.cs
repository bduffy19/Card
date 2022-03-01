using System;
using System.Collections.Generic;


    class Card
    {
        int rank;
        string suit;


        public Card(int rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }
    }
