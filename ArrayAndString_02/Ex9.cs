namespace PracticeLoopAndOperator;

public class Ex9
{
    public static void palindrome(){
        
    Console.WriteLine("Enter text:");
    string text = Console.ReadLine();
        
    var palindromes = text.Split(new[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\'', '"' }, 
            StringSplitOptions.RemoveEmptyEntries)
        .Where(IsPalindrome)
        .Select(w => w.ToLower())
        .Distinct()
        .OrderBy(w => w);
        
    Console.WriteLine("Palindromes: " + string.Join(", ", palindromes));
}

static bool IsPalindrome(string word)
{
    for (int i = 0; i < word.Length / 2; i++)
        if (word[i] != word[word.Length - 1 - i])
            return false;
    return word.Length > 1; 
}
}