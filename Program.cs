/*
You are developing a program to manage a call queue of customers using the Queue  in C#. 
The program creates a queue of callers and demonstrates the functionality of enqueueing elements 
into the queue and iterating over the elements and dequeuing.
Use linked lists. 
*/

namespace Assignment_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<string> myQueue = new();

            myQueue.Display(); //empty
            myQueue.Enqueue("Stephen");
            myQueue.Enqueue("Eduardo");
            myQueue.Enqueue("Deepali");
            myQueue.Display();
            Console.WriteLine($"--Dequeued {myQueue.Dequeue()}\n");
            myQueue.Display();
            Console.WriteLine($"--Dequeued {myQueue.Dequeue()}\n");
            Console.WriteLine($"--Dequeued {myQueue.Dequeue()}\n");
            Console.WriteLine($"--Dequeued {myQueue.Dequeue()}\n");
            myQueue.Enqueue("Jerome");
            myQueue.Enqueue("Angel");
            myQueue.Enqueue("Brandon");
            myQueue.Display();
            Console.WriteLine($"First in queue: {myQueue.ViewFirst()}\n");
            Console.WriteLine($"Last in queue: {myQueue.ViewLast()}\n");
        }
    }
}
