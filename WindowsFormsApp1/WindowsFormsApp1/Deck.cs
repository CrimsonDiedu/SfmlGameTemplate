using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSPG;

namespace Blackjack.myCards
{
    class Deck
    {
        Card[] cards;
        int MaxStack = 53;
        int stack = 53;

        public Deck(int size = 53) {
            cards = new Card[size];
            int face = 0;
            int num = 0;
            int k = 0;
            for (int i = 0; i < size / 13; i++)
            {//loop thru faces
                for (int j = 0; j < size / 4; j++)
                {//loop thru value
                    cards[k] = new Card(num+1, face);
                    num++;
                    k++;
                }
                num = 0;
                face++;
            }

        }

        public void DrawDeck()
        {
            //Console.WriteLine();
            string str = "";
            char c = ' ';
            int hsep = 8;
            int vsep = 5;
            int cx = 0;//= Console.WindowWidth;// - cards.Length * hsep;// Console.CursorLeft;
            int cy = Console.CursorTop;// -hsep;
            ConsoleColor cv = ConsoleColor.Black;

            ConsoleColor consoleColor;
            ///*
            for (int i = 0; i < cards.Length - 1; i++)
            {
                cx+=3;
                if(cx + hsep > Console.WindowWidth)
                {
                    cx = Console.WindowLeft;
                    cy += vsep + 1;
                    
                }
                if (i > 0) {
                    cv = cards[i - 1].col;
                }
                cards[i].DrawAt(cx, cy, cv);
                //Console.Write(cards[i].GetName());
                
            /*working draw program
                 for (int i = 0; i < cards.Length - 1; i++)
                {
                    str += "| " + cards[i].GetName() + " | ";
                    consoleColor = Console.ForegroundColor;
                    Console.ForegroundColor = cards[i].col;
                    if (i % 13 == 0) { Console.WriteLine(); }
                    Console.Write(str);
                    str = "";
                    Console.ForegroundColor = consoleColor;
                */}
            }
            //Console.Write(str);

        
        public void Shuffle()
        {
            Card pcard;
           
            int npos;
            //int pos2;
            for(int i = 0; i < cards.Length - 1; i++)
            {
                npos = Range(0, MaxStack-1);
                cards[i].SetDrawn(false);
                cards[npos].SetDrawn(false);

                pcard = cards[i];
                cards[i] = cards[npos];
                cards[npos] = pcard;
            }
            stack = MaxStack;
        }

        int Range(int min = 0, int max = 100)
        {
            int val;
            val = Utility.Rand() % (max - min) + Math.Abs(min);
            return val;
        }
        public Card DealCard(Hand hand) {

            Card c = cards[stack-2];
            stack--;
            c.SetDrawn(true);
            hand.TakeCard(c);
            return c;

        }
    }
}
