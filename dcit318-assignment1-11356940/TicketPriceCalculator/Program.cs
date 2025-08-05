Console.WriteLine("Ticket Price Calculator");
Console.WriteLine("======================");
Console.WriteLine("Standard ticket price: GHC10");
Console.WriteLine("Discounted price (seniors 65+ and children 12-): GHC7\n");

while (true)
{
    Console.Write("Enter your age (or 'q' to quit): ");
    string input = Console.ReadLine()?.Trim() ?? "";
    
    // Check if user wants to quit
    if (input.ToLower() == "q")
        break;

    // Validate input
    if (!int.TryParse(input, out int age) || age < 0 || age > 120)
    {
        Console.WriteLine("Invalid input. Please enter a valid age between 0 and 120.");
        continue;
    }

    // Calculate ticket price
    decimal price = (age <= 12 || age >= 65) ? 7.00m : 10.00m;
    string priceCategory = (age <= 12) ? "Child" : (age >= 65) ? "Senior" : "Adult";

    Console.WriteLine($"Age: {age} - {priceCategory} Price: GHC{price:F2}");
}

Console.WriteLine("\nThank you for using the Ticket Price Calculator!");
