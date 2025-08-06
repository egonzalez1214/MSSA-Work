namespace Assignment_5._2._2 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");
            Console.Write("How many numbers to print: ");
            int howMany = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");
            CountHeadRecursion(howMany);
        }

        static void CountHeadRecursion(int count) {
            //edge case
            if (count <= 0) {
                return;
            }
            
            //head recursion
            CountHeadRecursion(count - 1);

            //code
            Console.Write(count + " ");
        }
    }
}

/*
Write a program in C# Sharp to print the first n natural number using recursion.
--- Test Data ---
How many numbers to print: 10
Expected Output: 1 2 3 4 5 6 7 8 9 10 
*/