namespace UnderstandingTypes;

public class Ex3
{
    public static void userGuess()
    {
        Random rand = new Random();
        int numberToGuess = rand.Next(1, 4); 

        Console.Write("Guess a number between 1 and 3: ");
        string input = Console.ReadLine();

        bool isNumber = int.TryParse(input, out int guess);

        if (!isNumber)
        {
            Console.WriteLine(" not a valid number.");
            return;
        }

        if (guess < 1 || guess > 3)
        {
            Console.WriteLine("Your guess is outside the range (1 to 3).");
        }
        else if (guess < numberToGuess)
        {
            Console.WriteLine("Too low");
        }
        else if (guess > numberToGuess)
        {
            Console.WriteLine("Too high");
        }
        else
        {
            Console.WriteLine("Correct");
        }
    }
}