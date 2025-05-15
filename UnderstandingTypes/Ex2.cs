namespace UnderstandingTypes;

public class Ex2
{
    public static void printPyramid()
    {
        int totalRows = 5; 

        for (int row = 1; row <= totalRows; row++)
        {
            for (int space = 1; space <= totalRows - row; space++)
            {
                Console.Write(" ");
            }

            for (int star = 1; star <= (2 * row - 1); star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
  
}