using System.IO;

namespace Challenge_Lab_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserAccountCreate();
        }

        static void UserAccountCreate()
        {
            Console.Write("Please enter a username: ");
            string userName = Console.ReadLine();
            Console.Write("Please enter a password: ");
            string userPassword = Console.ReadLine();
            Console.WriteLine("Account created.");
            string path = @"C:\Users\latin\source\repos\Challenge Lab 2.2\Account Creation.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(userName);
                sw.WriteLine(userPassword);
            }
        }

        static string UserLogIn()
        {
            Console.WriteLine("Please enter your Login Information.");
            Console.Write("Username: ");
            string userInputName = Console.ReadLine();
            Console.Write("Password: ");
            string userInputPass = Console.ReadLine();
        }

        static void VerifyCredential()
        {
            
        }
    }
}
