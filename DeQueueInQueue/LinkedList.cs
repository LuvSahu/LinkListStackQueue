﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }


        public void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
                Console.WriteLine("Linked List :");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                    Console.Write("->");
                temp = temp.next;

            }
        }


        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }

        }

        public void addnodeatstart(Node node)
        {
            if (this.Head == null)
            {
                this.Head = node;
            }
            if (this.Tail == null)
            {
                this.Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
            Console.WriteLine("Add the start of the Linked List :" + node);
        }



        public bool Search(int data)
        {
            Node temp = this.Head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return true;
                }
                temp = temp.next;

            }
            return false;
        }

        public void InsertNode(Node Newnode, Node PerviousNode)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.data == PerviousNode.data)
                {
                    if (temp == Tail)
                    {
                        Tail = Newnode;
                    }
                    Newnode.next = temp.next;
                    temp.next = Newnode;
                    break;

                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("node is not Found");
            }
        }
        public void DeleteNodeAtFirst()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to be delete list is empty");
            }
            Node temp = this.Head;
            this.Head = this.Head.next;
            Console.WriteLine("Removed from linked list : " + temp.data);
        }



        public void DeleteNodeAtLast()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Nothing to Delete");
            }
            Node temp = this.Head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }
    }
}
