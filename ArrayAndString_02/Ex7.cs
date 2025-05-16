namespace PracticeLoopAndOperator;

public class Ex7
{
    public static void reverseMethod1()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();  
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        
        Console.WriteLine($"Reversed (Method 1): {reversed}");
    }

    public static void reverseMethod2()
    {
        
    string input = Console.ReadLine();
        
    Console.Write("Reversed (Method 2): ");
    for (int i = input.Length - 1; i >= 0; i--)
    {
        Console.Write(input[i]);
    }
    Console.WriteLine();
    }
}