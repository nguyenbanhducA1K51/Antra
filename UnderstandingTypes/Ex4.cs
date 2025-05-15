namespace UnderstandingTypes;

public class Ex4
{
    public static void birthdayCalculator()
    {
        Console.WriteLine("Enter your birth date (yyyy-MM-dd):");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime birthDate))
        {
            DateTime today = DateTime.Today;
            
            TimeSpan age = today - birthDate;
            int daysOld = (int)age.TotalDays;
            Console.WriteLine($"You are {daysOld} days old.");

            int daysRemaining = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = today.AddDays(daysRemaining);
            Console.WriteLine($"Next 10,000-day anniversary: {nextAnniversary:yyyy-MM-dd}");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please use yyyy-MM-dd (e.g., 1990-05-15).");
        }
    }
}