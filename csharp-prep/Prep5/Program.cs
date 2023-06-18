using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName =  PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);

        DisplayResult(userName, square);



        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Whats your name?: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Whats your favorite number?: ");
            int userNumber = int.Parse(Console.ReadLine());c
            return userNumber;
        }
        static int SquareNumber(int number)
        {
            int square = number*number;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        
    }
}