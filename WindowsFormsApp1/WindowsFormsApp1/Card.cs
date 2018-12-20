using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Blackjack.myCards
{
    class Card
    {
        int value;
        int face;
        string id;
        bool drawn;
        public ConsoleColor col;
        char cface;
        char cval;
        public Card(int val = 0, int f = -1, string i = "")
        {
            value = val;
            face = f;
            id = "";
            drawn = false;
            col = ConsoleColor.Black;

            UpdateId();
        }
        public void UpdateId()
        {
            id = "";
            switch (value)
            {
                
                case 1:
                    cval = 'A';
                    id += cval;
                    break;
                case 10:
                    cval = 'Ю';
                    id += cval;
                    break;
                case 11:
                    cval = 'J';
                    id += cval;
                    break;
                case 12:
                    cval = 'Q';
                    id += cval;
                    break;
                case 13:
                    cval = 'K';
                    id += cval;
                    break;
                case 0:
                    cval = ' ';
                    id += cval;
                    break;

                default:
                    id += value;
                    cval = id[id.Length - 1];
                    break;
            }
            switch (face)
            {
                case -1:
                    id += " ";
                    break;
              
                     case 0:
                    cface = '♠';
                    id += cface;
                        break;
                    case 1:
                    cface = '♣';
                    id += cface;
                        break;
                    case 2:
                    cface = '♥';
                    id += cface;
                    col = ConsoleColor.DarkRed;
                        break;
                    case 3:
                    cface = '♦';
                    id += cface;
                    col = ConsoleColor.DarkRed;
                        break;
                        
            }
        }
        public void SetValue(int v)
        {
            value = v;
        }
        public int GetValue()
        {
            int v = value;
            if (v > 10) { v = 10; }
            return v;
        }
        public void ToggleDrawn()
        {
            drawn = !drawn;
        }

        public string GetName()
        {
            return id;
        }
        public void SetName(string name)
        {
            id = name;
        }
        public bool GetDrawn()
        {
            return drawn;
        }
        public void SetDrawn(bool d)
        {
            drawn = d;
        }
        public char GetSValue()
        {
            return cval;
        }
        public char GetSFace()
        {
            return cface;
        }
        public void DrawAt(int cx, int cy,ConsoleColor lastCardCol = ConsoleColor.Black)
        {
            int hsep = 7;
            int vsep = 5;
            int mouse_x;
            int mouse_y;
            bool IsFirst = lastCardCol != ConsoleColor.Black;
            int px = Console.CursorLeft;
            int py = Console.CursorTop;
            ConsoleColor cc = Console.ForegroundColor;
            if (id != "XX") { Console.ForegroundColor = col; }
            
            for (int xx = 0; xx < hsep; xx++)
            {
                for(int yy = 0; yy < vsep; yy++)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    //▌▐▄▀
                    mouse_x = cx + xx;
                    mouse_y = cy + yy;
                    //Thread.Sleep(-1);
                    if (mouse_x >= 0 && mouse_x < Console.WindowWidth)
                    {
                        Console.SetCursorPosition(mouse_x, mouse_y);
                        if (xx == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            if (!IsFirst) {
                                Console.BackgroundColor = lastCardCol;
                            }
                            Console.Write("▐");//draw left border of card
                        }
                        else if (xx == hsep - 1)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Write("▌");//draw right border
                        }
                        else if (yy == 0)
                        {
                            Console.Write("▀");//Draw the top border of the card.
                        }
                        else if (yy == vsep - 1)
                        {
                            Console.Write("▄");//draw bottom border
                        }
                        else if (xx == 1 && yy == 1)
                        {
                            if(id == "XX")
                            {
                                Console.Write("X");
                            }
                            else
                            {
                            Console.Write(cval);
                            }
                        }
                        else if (xx == 1 && yy == 2)
                        {
                            if (id == "XX")
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write(cface);
                            }
                        }
                        else
                        {
                            
                            Console.Write(" ");
                            
                        }
                    }
                }

            }
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = cc;
        }

    }
}
