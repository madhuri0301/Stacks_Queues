using System;

namespace Stacks_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Push(70);
            linkedList.Push(30);
            linkedList.Push(56);
            Console.WriteLine("Stack Created");
            linkedList.Display();
            linkedList.IsEmpty();
        }
    }
}
