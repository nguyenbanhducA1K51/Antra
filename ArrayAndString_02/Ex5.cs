namespace PracticeLoopAndOperator;

public class Ex5
{
    public static void longestEqualSeg()
    {
        Console.WriteLine("Enter integers (space-separated):");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int maxCount = 1;
        int currentCount = 1;
        int number = arr[0];
        int startIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                number = arr[i];
                startIndex = i - maxCount + 1;
            }
        }
        Console.WriteLine($"\n Result"+maxCount);
    }
}