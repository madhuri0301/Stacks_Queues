using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks_Queues
{
    class LinkedList
    {
        private Node top; //variable
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
        public void Peek() //Method To The Peek The Element
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n{0} is in the top of the stack ", this.top.data);
        }

        public void Pop() //Method To PopThe Element
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty!!!! Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
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
        internal void IsEmpty() //Checking Stack Is Empty
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty now.");
        }

    }
}
