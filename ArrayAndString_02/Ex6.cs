namespace PracticeLoopAndOperator;

public class Ex6
{
    public static void mostFrequest()
    {
        int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 }; 
        
        var frequencyDict = new Dictionary<int, int>();
        int maxFrequency = 0;
        int mostFrequentNumber = numbers[0];
        foreach (int num in numbers)
        {
            if (frequencyDict.ContainsKey(num))
            {
                frequencyDict[num]++;
            }
            else
            {
                frequencyDict[num] = 1;
            }

            
            if (frequencyDict[num] > maxFrequency || 
                (frequencyDict[num] == maxFrequency && 
                 Array.IndexOf(numbers, num) < Array.IndexOf(numbers, mostFrequentNumber)))
            {
                maxFrequency = frequencyDict[num];
                mostFrequentNumber = num;
            }
        }

        Console.WriteLine($"Most frequent number: {mostFrequentNumber} (appears {maxFrequency} times)");
    }
}