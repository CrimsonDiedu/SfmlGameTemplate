using System;

namespace Snake
{


    namespace SnakeConsole
    {
        class Program
        {
            static void Main(string[] args)
            {
                Body head = new Body(5,5,30);
                while(head != null)
                {
                    head.BeginUpdate();
                    for (Body i = head; i != null; i = i.next)
                    {
                        i.Render();
                    }
                    Console.Clear();
                }
            }
        }
    }
}