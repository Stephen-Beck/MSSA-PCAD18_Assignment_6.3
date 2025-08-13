using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._3
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
    public class CustomQueue<T>
    {
        private int size;
        private Node<T> Front { get; set; }
        private Node<T> Rear { get; set; }

        public CustomQueue()
        {
            Front = null;
            Rear = null;
            size = 0;
        }

        private bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (IsEmpty()) Front = newNode;
            else Rear.Next = newNode;

            Rear = newNode;
            size++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Nothing dequeued, queue is empty.");
                return default;
            }

            T data = Front.Data;
            Front = Front.Next;
            size--;
            return data;
        }

        public T ViewFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.\n");
                return default;
            }

            return Front.Data;
        }

        public T ViewLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.\n");
                return default;
            }

            return Rear.Data;
        }

        public void Display()
        {
            if (IsEmpty()) Console.WriteLine("Queue is empty.\n");
            else
            {
                Console.Write("Current Queue: ");
                Node<T> temp = Front;
                while (temp != null)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
