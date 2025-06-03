using System;

class Menu
{
    public static void PrintAllReports() {
        Console.WriteLine("=== All Intel Reports ===");
        foreach (Intel intel in Intel.listOfIntel)
        {
            intel.PrintReport();
            Console.WriteLine("-------------------------");
        }
    }
    public static void Options()
    {
        Console.WriteLine("WELCOME TO STRIKE OPTIONS");
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Support special characters if needed
        Console.WriteLine("Here are your options:");
        Console.WriteLine("1. Show all terrorists");
        Console.WriteLine("2. Show all intel reports");
        Console.WriteLine("3. Execute a strike");
        Console.WriteLine("4. Exit");
        string selectedOption = Console.ReadLine().Trim().ToLower();
        switch (selectedOption)
        {
            case "show all intel reports":
            case "2":
                PrintAllReports();
                break;
            case "Show all terrorists":

            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;

        }
    }
}
