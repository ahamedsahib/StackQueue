using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Queue Program");
            QueueOperation queue = new QueueOperation();
            queue.Enqueue(30);
            queue.Enqueue(50);
            queue.Enqueue(76);
            queue.Display();

            queue.Dequeue();
            queue.Dequeue();
            queue.Display();
        }
    }
}
