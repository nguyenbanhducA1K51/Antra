namespace PracticeLoopAndOperator;

public class Ex3
{
    public static void findPrimes()
    {
        int start = 10;
        int end = 20;
        List<int> primesList = new List<int>();

        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                primesList.Add(num);
            }
        }

        Console.WriteLine("Primes: " + string.Join(", ", primesList));

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}