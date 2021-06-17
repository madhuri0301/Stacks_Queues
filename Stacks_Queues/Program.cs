using System;

namespace Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Enqueue(56);
                linkedList.Enqueue(30);
                linkedList.Enqueue(70);
                Console.WriteLine("Queue is Created"); //First-In-First-Out
                linkedList.Display();
            }
        }
    }
}
