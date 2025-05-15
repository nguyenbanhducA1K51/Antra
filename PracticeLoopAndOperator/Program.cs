
// 1
static void exercise1() {

    Console.WriteLine("sbyte:   " + sbyte.MinValue   + "  " + sbyte.MaxValue);
    Console.WriteLine("byte:    " + byte.MinValue    + "  " + byte.MaxValue);
    Console.WriteLine("short:   " + short.MinValue   + "  " + short.MaxValue);
    Console.WriteLine("ushort:  " + ushort.MinValue  + "  " + ushort.MaxValue);
    Console.WriteLine("int:     " + int.MinValue     + "  " + int.MaxValue);
    Console.WriteLine("uint:    " + uint.MinValue    + "  " + uint.MaxValue);
    Console.WriteLine("long:    " + long.MinValue    + "  " + long.MaxValue);
    Console.WriteLine("ulong:   " + ulong.MinValue   + "  " + ulong.MaxValue);
    Console.WriteLine("float:   " + float.MinValue   + "  " + float.MaxValue);
    Console.WriteLine("double:  " + double.MinValue  + "  " + double.MaxValue);
    Console.WriteLine("decimal: " + decimal.MinValue + "  " + decimal.MaxValue);
}

// exercise1();

static void exercise2()
{
    Console.Write("Enter number of centuries: ");
    int centuries = int.Parse(Console.ReadLine());

    int years = centuries * 100;
    int daysInYear = 365; 
    int days = years * daysInYear;

    long hours = days * 24L;
    long minutes = hours * 60L;
    long seconds = minutes * 60L;
    long milliseconds = seconds * 1000L;
    decimal microseconds = (decimal)milliseconds * 1000;
    decimal nanoseconds = microseconds * 1000;

    Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
                      $"{minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = " +
                      $"{microseconds} microseconds = {nanoseconds} nanoseconds");
}
// exercise2();

// Practice loops and operators 
static void exercise_2_1()
{
    // int max = 500;
    // for (byte i = 0; i < max; i++)
    // {
    //     Console.WriteLine(i);
    // }
    // warning: the condition is always true 
    
    Random rand = new Random();
    int numberToGuess = rand.Next(1, 4); 

    Console.Write("Guess a number between 1 and 3: ");
    string input = Console.ReadLine();

    bool isNumber = int.TryParse(input, out int guess);

    if (!isNumber)
    {
        Console.WriteLine("That's not a valid number.");
        return;
    }

    if (guess < 1 || guess > 3)
    {
        Console.WriteLine("Your guess is outside the valid range (1 to 3).");
    }
    else if (guess < numberToGuess)
    {
        Console.WriteLine("Too low!");
    }
    else if (guess > numberToGuess)
    {
        Console.WriteLine("Too high!");
    }
    else
    {
        Console.WriteLine("Correct! You guessed the number.");
    }
}

static void exercise_2_2()
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
// exercise_2_2();

static void exercise_2_3()
{
    DateTime birthDate = new DateTime(2000, 1, 1); 

    DateTime today = DateTime.Today;

    TimeSpan age = today - birthDate;

    Console.WriteLine("You are " + age.Days + " days old.");
}
// exercise_2_3();
static void exercise_2_4()
{
    int hour = DateTime.Now.Hour; 

    Console.WriteLine("Current hour: " + hour);

    if (hour >= 5 && hour < 12)
    {
        Console.WriteLine("Good Morning");
    }

    if (hour >= 12 && hour < 17)
    {
        Console.WriteLine("Good Afternoon");
    }

    if (hour >= 17 && hour < 21)
    {
        Console.WriteLine("Good Evening");
    }

    if ((hour >= 21 && hour <= 23) || (hour >= 0 && hour < 5))
    {
        Console.WriteLine("Good Night");
    }
}

static void exercise_2_5()
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
//practice array

static void exercise_3_3()
{
    List<string> groceryList = new List<string>();

    while (true)
    {
        Console.WriteLine("\nCurrent list:");
        if (groceryList.Count == 0)
        {
            Console.WriteLine("The list is empty.");
        }
        else
        {
            foreach (string item in groceryList)
            {
                Console.WriteLine(item);
            }
        }

        Console.WriteLine("\nEnter an operation (+ item, - item, -- to clear the list, or exit to quit):");
        string input = Console.ReadLine();

        if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
            break;
        }

        if (input.StartsWith("+"))
        {
            string itemToAdd = input.Substring(1).Trim(); 
            if (!string.IsNullOrWhiteSpace(itemToAdd))
            {
                groceryList.Add(itemToAdd);
                Console.WriteLine($"Added: {itemToAdd}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please provide a valid item.");
            }
        }
        else if (input.StartsWith("-"))
        {
            string itemToRemove = input.Substring(1).Trim(); 
            if (!string.IsNullOrWhiteSpace(itemToRemove) && groceryList.Contains(itemToRemove))
            {
                groceryList.Remove(itemToRemove);
                Console.WriteLine($"Removed: {itemToRemove}");
            }
            else
            {
                Console.WriteLine("Item not found in the list or invalid input.");
            }
        }
        else if (input.Equals("--"))
        {
            groceryList.Clear();
            Console.WriteLine("The list has been cleared.");
        }
        else
        {
            Console.WriteLine("Invalid operation. Please enter a valid command.");
        }

    }
}
// exercise_3_3();

static void exercise_3_4()
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
// exercise_3_4();
static void exercise_3_5()
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
// exercise_3_5();

static void exercise_3_6()
{
    Console.WriteLine("Enter integers (space-separated):");
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int maxCount = 1;
    int currentCount = 1;
    int number = arr[0];
    int startIndex = 0;

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == arr[i - 1])
        {
            currentCount++;
        }
        else
        {
            currentCount = 1;
        }

        if (currentCount > maxCount)
        {
            maxCount = currentCount;
            number = arr[i];
            startIndex = i - maxCount + 1;
        }
    }
    Console.WriteLine($"\n Result"+maxCount);
}
exercise_3_6();