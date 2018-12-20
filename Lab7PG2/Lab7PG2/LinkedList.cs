using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7PG2
{
    class LinkedList<T>
    {
        int size;
        //T typeofdata;
        class Node
        {
            public T data;
            public Node Next;

            public Node()
            {
                //data = d;
                //Next = null;
            }

            

        }

        Node head;
        LinkedList()
        {
            
            size = 0;
            head = null;
        }
        void AddHead(T data)
        {
            Node newNode = new Node(), node = head;

            newNode.data = data;

            while(node.Next != null){
                node = node.Next;
            }
            node.Next = newNode;
            head = newNode;
            size++;
        }

        int Remove(T data)
        {
            int instances = 0;
            Node node = head;
            while (node.Next != null)
            {
                if(node.data.GetType() == data.GetType())
                {
                    //remove the node
                }
            }

            return instances;
        }

    }


}
