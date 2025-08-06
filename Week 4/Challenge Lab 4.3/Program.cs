namespace ChallengeLab_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Reversing Arrays --");
            ReverseStringArray();
            ReverseStringArray2();
            ReverseStringArray3();
        }

        static void ReverseStringArray()
        {
            string[] inputArray = { "h", "e", "l", "l", "o" };
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine("\n-------------------------");

            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                for (int j = inputArray.Length - 1 - i; j >= inputArray.Length -1 -i; j--)
                {
                    string temp = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine("\n-------------------------");
        }
        static void ReverseStringArray2()
        {
            string[] inputArray = { "H", "a", "n", "n", "a", "h" };
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine("\n-------------------------");

            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                for (int j = inputArray.Length - 1 - i; j >= inputArray.Length - 1 - i; j--)
                {
                    string temp = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine("\n-------------------------");
        }
        static void ReverseStringArray3()
        {
            string[] inputArray = { "s", "h", "o", "r", "t", "e", "r" };
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine("\n-------------------------");

            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                    string temp = inputArray[i];
                    inputArray[i] = inputArray[inputArray.Length - i - 1];
                    inputArray[inputArray.Length - i - 1] = temp;
            }
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
            Console.WriteLine("\n-------------------------");
        }
    }
}
