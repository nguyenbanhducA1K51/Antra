namespace OOP_03;

public class Ex2
{
    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
            return 1;
        
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}