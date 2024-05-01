using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string strMagicNumber = Console.ReadLine();
        // int magicNumber = int.Parse(strMagicNumber);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guessNumber = magicNumber + 1;

        while (guessNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            string strGuessNumber = Console.ReadLine();
            int guessNumberInLoop = int.Parse(strGuessNumber);

            guessNumber = guessNumberInLoop;

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            } 

            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
            
        }
    }
}