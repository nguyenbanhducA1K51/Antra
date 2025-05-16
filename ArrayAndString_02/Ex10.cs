namespace PracticeLoopAndOperator;

public class Ex10
{
    public static void urlParser()
    {
        Console.WriteLine("Enter URL to parse:");
        string url = Console.ReadLine();
        try
        {
            Uri uri = new Uri(url);
            Console.WriteLine($"Protocol: {uri.Scheme}");
            Console.WriteLine($"Server: {uri.Host}");
            Console.WriteLine($"Resource: {uri.AbsolutePath.TrimStart('/')}");
        }
        catch (UriFormatException)
        {
            Console.WriteLine("Invalid URL format for Uri class");
        }
    }
}