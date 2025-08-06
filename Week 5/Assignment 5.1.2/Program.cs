namespace Assignment_5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SumIndividualNums();
        }

        static void SumIndividualNums()
        {
            Console.Write("Enter a number: ");
            int userNum = int.Parse(Console.ReadLine());
            int tempnum = 0;
            int total = 0;
            while (userNum > 0)
            {
                tempnum = userNum % 10;
                total = total + tempnum;
                userNum = userNum / 10;
            }
            Console.WriteLine("Total of the individual numbers is: " + total);
        }
    }
}

/*
Write a program in C# Sharp to create a function to calculate
the sum of the individual digits of a given number.
Test Data:
Enter a number: 1234
Expected Output:
The sum of the digits of the number 1234 is: 10
*/