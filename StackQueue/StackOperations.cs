using System;
namespace StackQueue
{
    public class StackOperations
    {
        Node top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
        }
        public void pop()
        {
            while (top != null)
            {
                Console.WriteLine($"the top element is {top.data}");
                Display();
                if (top.next== null)
                {
                    Console.WriteLine("All the Elements are popped");
                    break;
                }

                top = top.next;
            }
        }
        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine(" -------");
            while (temp != null)
            {
                Console.WriteLine($"|__{temp.data}___|");
                temp = temp.next;
            }
        }

    }


}
