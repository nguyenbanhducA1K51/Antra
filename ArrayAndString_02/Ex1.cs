using System;
namespace PracticeLoopAndOperator;

public class Ex1
{
    public static void copyArray()
    {
        int[] originalArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] copiedArray = new int[originalArray.Length];

        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }

      
    }
}