namespace PracticeLoopAndOperator;

public class Ex2
{
    public static void manageList()
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
}