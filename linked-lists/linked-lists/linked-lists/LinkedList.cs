﻿using System;
using System.Collections.Generic;
using System.Text;

namespace linkedLists
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
    }
}
