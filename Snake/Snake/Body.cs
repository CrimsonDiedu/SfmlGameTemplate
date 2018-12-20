using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Body
    {
        Body next, prev,tail;
        int px { get; set; }
        int py { get; set; }
        int clampx { get; set; }
        int clampy { get; set; }

        short dir = 0;
        
        enum Dir
        {
            Right,
            Up,
            Left,
            Down
        }
        public Body()
        {
            next = prev = null;
            tail = this;
            px = 0;
            py = 0;
        }
        public bool HasPoint(int x, int y)
        {
            if(x != px || y != py)
            {
                if (prev != null)
                {
                    return prev.HasPoint(x, y);
                }
                else {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        public Body(int x, int y, int perimeter = 20)
        {
            next = prev = null;
            tail = this;
            px = x;
            py = y;
            clampx = perimeter;
            clampy = perimeter;
        }

        public void BeginUpdate()
        {
            tail.Update();
        }
        public void Update()
        {
            ConsoleKeyInfo cc = new ConsoleKeyInfo();
            
            
            if(cc.Key == ConsoleKey.Q)
            {
                //debugging body creation;
                if(prev == null)
                {
                    prev = new Body(px,py,clampx);
                    tail = prev;
                }
                else
                {
                    tail = prev.tail;
                }
            }
            if (next != null)//move to next cell's position
            {
                px = next.px;
                py = next.py;
                next.Update();//updates from the tail up
            }//if there is no next cell(at the head)
            else
            {

                if (cc.KeyChar != '\0')
                {
                    Console.Beep(1000, 100);
                    if (cc.Key == ConsoleKey.W && dir != 3)
                    {
                        dir = 1;
                    }
                    else if (cc.Key == ConsoleKey.S && dir != 1)
                    {
                        dir = 3;
                    }

                    if (cc.Key == ConsoleKey.D && dir != 2)
                    {
                        dir = 0;
                    }
                    else if (cc.Key == ConsoleKey.A && dir != 0)
                    {
                        dir = 2;
                    }
                }

                switch (dir)
                {
                    case 0:
                        px++;
                        break;
                    case 1:
                        py--;
                        break;
                    case 2:
                        px--;
                        break;
                    case 3:
                        py++;
                        break;
                }
                if (px > clampx - 1)
                {
                    px = 0;
                }
                else if (px < 0)
                {
                    px = clampx - 1;
                }

                if (py > clampy - 1)
                {
                    py = 0;
                }
                else if(py < 0)
                {
                    py = clampy - 1;
                }
            }
        }
    }
}
