namespace PracticeLoopAndOperator;

public class Ex8
{
    public static void reverse()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        Console.WriteLine(string.Join(" ", words));
    }
}