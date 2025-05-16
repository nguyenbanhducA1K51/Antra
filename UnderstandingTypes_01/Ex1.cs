// See https://aka.ms/new-console-template for more information

class Ex1
{
    public static void FizzBuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string output = "";
            if (i % 3 == 0) output += "Fizz";
            if (i % 5 == 0) output += "Buzz";
            Console.WriteLine(output == "" ? i.ToString() : output);
        }
    }

    public static void byteVar()
    {
        // Warning: Expression is always true
        int max = 500;
        for (byte i = 0; i < max; i++)
        {
            Console.WriteLine(i);
        }
    }

    
   
}