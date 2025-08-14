namespace Assignment_5._3._2 {

    internal class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello, World!");

            //prompt for how many steps

            Console.Write("How many steps are you climbing: ");
            int stepCount = int.Parse(Console.ReadLine());
            int fibsNumber = GetFibsNumber(stepCount);
            Console.WriteLine($"There are '' {fibsNumber} '' possible combinations.");
        }

        static int GetFibsNumber(int stepCount) {
            if (stepCount <= 1) {
                return stepCount;
            }
            return GetFibsNumber(stepCount - 1) + GetFibsNumber(stepCount - 2);
        }
    }
}
