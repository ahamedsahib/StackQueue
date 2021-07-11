using System;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Queue Program");
            StackOperations stack = new StackOperations();
            stack.Push(50);
            stack.Push(76);
            stack.Push(30);

            stack.Display();
        }
    }
}
