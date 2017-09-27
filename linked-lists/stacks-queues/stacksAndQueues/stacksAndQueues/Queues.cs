using System;
using System.Collections.Generic;
using System.Text;

namespace stacksAndQueues
{
    class Queues
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Queue(int Data)
        {
            Head = new Node(Data);
            Tail = Head;
        }
        public void Enqueue(int data)
        {
            Tail.Next = new Node(data);
            Tail = Tail.Next;
        }

        public int Dequeue()
        {
            if(Head == Tail)
            {
                Node temp = Head.Next;
                Head.Next = null;
                int Value = Head.Data;
                Head = temp;
                return Value;
            }
        }
    }
}
