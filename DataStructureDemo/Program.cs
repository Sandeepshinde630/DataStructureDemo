using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();

            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.Push(70);
            //linkedListStack.Push(56);
            //linkedListStack.Push(30);
            //linkedListStack.Peek();
            //linkedListStack.Pop();
            //linkedListStack.isEmpty();
            //linkedListStack.Display();

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            
        }
    }
}
