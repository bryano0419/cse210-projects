using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the magic number game!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        // Console.WriteLine(number);

        int number2 = 0; 

        while (number != number2)
        {
            Console.WriteLine("What is your guess?");
            string userInput2 = Console.ReadLine();
            number2 = int.Parse(userInput2); 
            if (number == number2)
            {
                Console.WriteLine("You Guessed it!");
            }
            else if (number < number2)
            {
                Console.WriteLine("Lower");
            }
            else if (number > number2)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}
