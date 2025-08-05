Console.WriteLine("Triangle Type Identifier");
Console.WriteLine("========================");

while (true)
{
    Console.WriteLine("\nEnter the lengths of the three sides of the triangle (or 'q' to quit):");
    
    // Get first side
    double side1 = GetValidDouble("Enter length of side 1: ");
    if (double.IsNaN(side1)) break;
    
    // Get second side
    double side2 = GetValidDouble("Enter length of side 2: ");
    if (double.IsNaN(side2)) break;
    
    // Get third side
    double side3 = GetValidDouble("Enter length of side 3: ");
    if (double.IsNaN(side3)) break;
    
    // Check if the sides can form a valid triangle
    if (!IsValidTriangle(side1, side2, side3))
    {
        Console.WriteLine("These sides cannot form a valid triangle. The sum of any two sides must be greater than the third side.");
        continue;
    }
    
    // Determine the type of triangle
    string triangleType = DetermineTriangleType(side1, side2, side3);
    Console.WriteLine($"\nTriangle with sides {side1}, {side2}, {side3} is: {triangleType}");
}

Console.WriteLine("\nThank you for using the Triangle Type Identifier!");

// Helper method to get a valid positive double from user input
static double GetValidDouble(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string input = Console.ReadLine()?.Trim() ?? "";
        
        if (input.ToLower() == "q")
            return double.NaN;
            
        if (double.TryParse(input, out double value) && value > 0)
            return value;
            
        Console.WriteLine("Invalid input. Please enter a positive number.");
    }
}

// Helper method to check if three sides can form a valid triangle
static bool IsValidTriangle(double a, double b, double c)
{
    return a + b > c && a + c > b && b + c > a;
}

// Helper method to determine the type of triangle
static string DetermineTriangleType(double a, double b, double c)
{
    if (a == b && b == c)
        return "Equilateral (all sides equal)";
        
    if (a == b || a == c || b == c)
        return "Isosceles (two sides equal)";
        
    return "Scalene (no sides equal)";
}
