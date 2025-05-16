namespace OOP_03;

public class Ex1
{
    static void run()
    {
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers()
    {
        return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }

    static void Reverse(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }
    }

    static void PrintNumbers(int[] array)
    {
        Console.WriteLine("Reversed array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}