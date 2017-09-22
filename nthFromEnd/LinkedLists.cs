using System;
using System.Collections.Generic;
using System.Text;

namespace FIndMiddle
{
    public class LinkedList
    {
        private Node head;
        private Node current;
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }

        public void PrintAllNodes()
        {
            Console.Write("Head --"); //head sentinel
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("--");
            }
            Console.Write("null"); //tail sentinel
        }

        //public void FindMiddle()
        //{
        //    Node slow = head;
        //    Node fast = head;
        //    while (fast != null && fast.Next != null)
        //    {
        //        fast = fast.Next.Next;
        //        slow = slow.Next;
        //    }
        //    Console.WriteLine("The middle node is " + slow.Value);
        //}

        public void NthFromEnd(int n)
        {
            Node second = head;
            Node current = head;

            for(int i = 0; i < n-1; i++)
            {
                if (current != null)
                {
                    current = current.Next;
                }
                else
                {
                    Console.WriteLine("null");   //if n is bigger than list length
                }
            }
            while(current.Next != null)
            {
                current = current.Next;
                second = second.Next;
            }
            Console.WriteLine(second.Value + " is " + n + " from the end");
        }



        public void DeleteNode(string val)
        {
            var node = head;
            Node currNode = head;
            Node prevNode = null;
            while (node != null)
            {
                currNode = node;
                if ((string)node.Value == val)
                {
                    if (prevNode != null)
                    {
                        prevNode.Next = currNode.Next;
                    }
                    else
                    {
                        head = head.Next;
                    }
                    break;
                }
                prevNode = currNode;
                node = node.Next;
            }
            PrintAllNodes();
        }

    }
}