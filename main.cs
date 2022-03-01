using System;

class Program {
  public static void Main (string[] args) {
        {
            Card c = new Card(5, "Hearts");

            Console.WriteLine(c.Rank + " " + c.Suit);
            c.Rank = 10;
            Console.WriteLine(c.Rank + " " + c.Suit);

          Deck deck = new Deck();
          deck.Shuffle();
          deck.Print();

          //for(int i=0; i<52; i++){
          //  Card topCard = deck.TopCard();
          //  if(topCard != null)
           //   Console.WriteLine(topCard.Rank + " " + topCard.Suit);
           // }


        }
    }
  }
