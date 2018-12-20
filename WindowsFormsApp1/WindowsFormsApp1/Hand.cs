using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.myCards
{
    class Hand
    {
        int sum;
        Card[] myCards;

        public Hand(int size = 12)
        {
            sum = 0;
            myCards = new Card[size];
            ClearHand();
        }
        public void ClearHand()
        {
            for (int i = 0; i < myCards.Length - 1; i++)
            {
                myCards[i] = new Card();
            }
        }
        public int GetSum()
        {
            sum = 0;
            int aces = 0;
            int c;
            for (int i = 0; i < myCards.Length-1; i++)
            {
                Card card = myCards[i];
                if (card != null)
                {
                    c = card.GetValue();
                    sum += c;
                    if(c == 1)
                    {
                        aces++;
                    }
                }
            }
            while(sum <= 11 && aces > 0)
            {
                aces--;
                sum += 10;
            }
            return sum;
        }

        public void TakeCard(Card card)
        {
            for(int i = 0; i < myCards.Length-1; i++)
            {
                if (myCards[i].GetValue() == 0)
                {
                    myCards[i] = card;
                    break;
                }
            }
        }

        public string GetCards()
        {
            string s = "";
            Card card;
            int cx = Console.CursorLeft;
            int cy = Console.CursorTop;
            for (int i = 0; i < myCards.Length - 1; i++)
            {
                card = myCards[i];
                card.UpdateId();
                s += card.GetName() + "   ";// + ";";
                if (card.GetValue() != 0)
                {
                    card.DrawAt(cx, cy);
                    cx += 7;
                }
            }
            return "";//s;
        }
        public string GetHiddenCards()
        {
            string s = "XX   ";
            Card card;
            int cx = Console.CursorLeft;
            int cy = Console.CursorTop;
            myCards[0].SetName("XX");
            for (int i = 0; i < myCards.Length - 1; i++)
            {
                card = myCards[i];
                s += card.GetName() + "   ";// + ";";
                if(card.GetValue() != 0)
                {
                    card.DrawAt(cx, cy);
                    cx += 7;
                }
            }
            return "";//s;
        }
    }
}
/*
 
      
     
     |5|
     |S|
     


*/
