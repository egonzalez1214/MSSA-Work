namespace Assignment_5._2._3 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");
            Console.Write("How many numbers to print: ");
            int howMany = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");
            CountTailRecursion(howMany);
        }

        static void CountTailRecursion(int count) {
            //edge case
            if (count <= 0) {
                return;
            }

            //code
            Console.Write(count + " ");

            //tail recursion
            CountTailRecursion(count - 1);
        }
    }
}

/*
Write a program in C# Sharp to print numbers from n to 1 using recursion.
--- Test Data ---
How many numbers to print: 10
Expected Output: 10 9 8 7 6 5 4 3 2 1 
*/