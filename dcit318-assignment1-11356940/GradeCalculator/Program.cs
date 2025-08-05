Console.WriteLine("Grade Calculator");
Console.WriteLine("================");

while (true)
{
    Console.Write("\nEnter a numerical grade (0-100) or 'q' to quit: ");
    string input = Console.ReadLine() ?? "";
    
    // Check if user wants to quit
    if (input.ToLower() == "q")
        break;

    // Validate input
    if (!double.TryParse(input, out double grade) || grade < 0 || grade > 100)
    {
        Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        continue;
    }

    // Determine letter grade
    string letterGrade;
    if (grade >= 90)
        letterGrade = "A";
    else if (grade >= 80)
        letterGrade = "B";
    else if (grade >= 70)
        letterGrade = "C";
    else if (grade >= 60)
        letterGrade = "D";
    else
        letterGrade = "F";

    Console.WriteLine($"Grade: {grade}% = {letterGrade}");
}

Console.WriteLine("\nThank you for using the Grade Calculator!");
