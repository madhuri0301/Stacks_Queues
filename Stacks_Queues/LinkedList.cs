using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
   class LinkedList
    {
        Node head = null;
        internal void Enqueue(int data) // Method To Adding Elements To Queue
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }
        public void Display() // Method To Display Elements In Queue
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.Write(temp.data + "\n");
            }
        }

    }
}
