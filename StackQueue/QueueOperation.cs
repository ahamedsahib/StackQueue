using System;
namespace StackQueue
{
    public class QueueOperation
    {
        Node front;
        Node rear;
        public void Enqueue(int val)
        {
            Node node = new Node(val);
            if (this.front == null)
            {

                this.front = this.rear = node;

            }
            this.rear.next = node;
            this.rear = node;
        }
        public void Display()
        {
            Console.WriteLine("\n");
            Node temp = this.front;
            while (temp != null)
            {
                Console.Write($"|{temp.data}|");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is Empty");
                
            }
            else
            {
                Console.WriteLine($"\n{front.data} is removed");
                this.front = this.front.next;
            }
        }
    }
}
