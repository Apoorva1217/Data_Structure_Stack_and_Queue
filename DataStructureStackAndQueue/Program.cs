using System;

namespace DataStructureStackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);
            linkedListStack.Display();

            linkedListStack.Peek();
            linkedListStack.Pop();
            linkedListStack.Display();

            linkedListStack.IsEmpty();
            linkedListStack.Display();

            Console.WriteLine("/**************************/");

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();

            linkedListQueue.Dequeue();
            linkedListQueue.Display();
        }
    }
}
