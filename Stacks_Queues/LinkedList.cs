using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    class LinkedList
    {
        private Node top;
        public LinkedList()
        {
            this.top = null;
        }
        internal void Push(int value) // method to push The Elements in stack
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
                this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        public void Display() //method use To Display
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
