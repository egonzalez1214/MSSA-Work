namespace Assignment_6._3._1 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            CustomerQueue queue = new CustomerQueue();
            //Initial Queue
            Console.WriteLine("Initial customer queue:");
            queue.Display();
            Console.WriteLine("\n------------------------------\n");
            //Adding to Queue
            Console.WriteLine("Adding Brock to the queue:");
            queue.Enqueue("Brock");
            queue.Display();
            Console.WriteLine("\n------------------------------\n");
            //Dequeue two customers
            Console.WriteLine("Dequeueing two customers:");
            queue.Dequeue();
            queue.Dequeue();
            queue.Display();
        }
    }
}

/*
You are developing a program to manage a call queue of customers using the Queue
in C#. The program creates a queue of callers and demonstrates the functionality
of enqueueing elements into the queue and iterating over the elements and dequeuing.
Use linked lists. 
*/