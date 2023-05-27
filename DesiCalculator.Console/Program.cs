using DesiCalculator.Console;

Console.WriteLine("Welcome to Desi Calculator!");
Console.WriteLine("Type 'exit' to quit the program");
Console.WriteLine("Press 'Enter' to continue");

while (Console.ReadLine() != "exit")
{
    
    Console.WriteLine("Enter the package height in cm:");
    string? height = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(height) || double.TryParse(height, out double _) == false)
    {
        Console.WriteLine("Height is not valid");
        Console.WriteLine("Press 'Enter' to continue or type 'exit' to quit the program");
        continue;
    }
    
    Console.WriteLine("Enter the package width in cm:");
    
    string? width = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(width) || double.TryParse(width, out double _) == false)
    {
        Console.WriteLine("Width is not valid");
        Console.WriteLine("Press 'Enter' to continue or type 'exit' to quit the program");
        continue;
    }    
    
    Console.WriteLine("Enter the package length in cm:");
    
    string? length = Console.ReadLine();
    
    if (string.IsNullOrWhiteSpace(length) || double.TryParse(length, out double _) == false)
    {
        Console.WriteLine("Height is not valid");
        Console.WriteLine("Press 'Enter' to continue or type 'exit' to quit the program");
        continue;
    }
    
    Console.WriteLine("Enter the package weight in kg:");

    string? weight = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(weight) && double.TryParse(weight, out double _) == false)
    {
        Console.WriteLine("Weight is not valid");
        Console.WriteLine("Press 'Enter' to continue or type 'exit' to quit the program");
        continue;
    }
    
    if (string.IsNullOrWhiteSpace(weight))
    {
        weight = "0";
    }
    
    Calculator calculator = new Calculator(double.Parse(height), double.Parse(width), double.Parse(length), double.Parse(weight));
    
    double desi = calculator.CalculateDesi();
    
    Console.WriteLine($"Your desi is: {desi}");
    
    
    Console.WriteLine("Press 'Enter' to continue or type 'exit' to quit the program");
}