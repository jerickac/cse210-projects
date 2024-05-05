using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string strUserFavoriteNumber = Console.ReadLine();
        int userFavoriteNumber = int.Parse(strUserFavoriteNumber);
        return userFavoriteNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int result = userNumber * userNumber;
        return result;
    }

    static void DisplayResult()
    {
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);

        Console.WriteLine($"Your name is {userName} and your favorite number squared is {squareNumber}");
    }
}