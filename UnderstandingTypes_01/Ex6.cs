namespace UnderstandingTypes;

public class Ex6
{
    public static void countTo24()
    {
        for (int increment = 1; increment <= 4; increment++)  
        {
            for (int i = 0; i <= 24; i += increment)  
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");  
        }
    }
}