namespace PracticeLoopAndOperator;

public class Ex4
{
    public static void rotateArray()
    {
        Console.WriteLine("Enter the list (separated by space):)");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse); 

        Console.WriteLine("Enter the number of rotations (k):");
        int k = int.Parse(Console.ReadLine()); 

        int n = arr.Length;  

        k = k % n;

        int []totalSum = new int[n];

        for (int l = 0; l < k; l++)
        {
            int lastElement = arr[arr.Length - 1]; 
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];  
            }
            arr[0] = lastElement; 
            for (int j = 0; j < n; j++)
            {
                totalSum[j] += arr[j];
            }

        
        }

        Console.WriteLine($"\n Output:"+string.Join(" ", totalSum));
    }
}