namespace Assignment_7._2._1 {
    internal class Program {
        /*
        Implement shell sort on an unsorted array of numbers.
        Take the array input from user.
        */
        static void Main(string[] args) {
            Console.WriteLine("Hello, World!\n");
            int[] userNums = GetThisArray();
            ShellSmash(userNums);
        }

        static int[] GetThisArray() {
            Console.Write("Give me a list of numbers: ");
            string userInput = Console.ReadLine();
            int[] userNums = Array.ConvertAll(
                userInput.Split(new[] { ' ' }), int.Parse
            );
            Console.WriteLine();
            return userNums;
        }

        static void ShellSmash(int[] userNums) {
            Console.Write($"Before ShellSort:" +
                           "\n|");
            foreach (int n in userNums) {
                Console.Write($"{n}|");
            }
            Console.WriteLine("\n");

            int gap = userNums.Length / 2;
            int i, j;
            while (gap > 0) {
                i = gap;
                while (i < userNums.Length) {
                    int temp = userNums[i];
                    j = i - gap;
                    while (j >= 0 && userNums[j] > temp) {
                        userNums[j + gap] = userNums[j];
                        j -= gap;
                    }
                    userNums[j + gap] = temp;
                    i++;
                }
                gap /= 2;
            }

            Console.Write($"After ShellSort:" +
                           "\n|");
            foreach (int n in userNums) {
                Console.Write($"{n}|");
            }
            Console.WriteLine();
        }
    }
}
/*
I get ShellSort and can follow along... but I don't know if I can
implement this out of nowhere... I would need to know it is needed
to even come close to coming up with it...
*/