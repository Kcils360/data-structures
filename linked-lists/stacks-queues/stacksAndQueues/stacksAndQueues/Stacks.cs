using System;
using System.Collections.Generic;
using System.Text;

namespace stacksAndQueues
{
    class Stacks
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Stack(int Data)
        {
            Head = new Node(Data);
        }
        public void Push(int Data)
        {
            Node temp = Head;
            Head = new Node(Data);
            Head.Next = temp;
        }
        public int Pop()
        {
            if (Head == Tail)
            {
                Tail = null;
            }
            Node temp = Head.Next;
            int value = Head.Data;
            Head = temp;
            return value;
        }
        
    }
}
