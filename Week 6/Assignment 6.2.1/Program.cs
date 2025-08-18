namespace Assignment_6._2._1 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");

            // original stack
            TheStack stack = new TheStack();
            stack.Display();
            Console.WriteLine("\n-------------------------\n");
            // add two to stack
            Console.WriteLine("Add 40 and 25 to stack.");
            stack.Push(40);
            stack.Push(25);
            stack.Display();
            Console.WriteLine("\n-------------------------\n");
            // pop three from stack
            Console.WriteLine("Pop three from stack.");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Display();
        }
    }
}

/*
Write a C# program to implement a stack by using array
with push and pop operations. 
*/