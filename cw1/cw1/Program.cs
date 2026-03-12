Console.WriteLine("Select a program:");
Console.WriteLine("1. Calculator");
Console.WriteLine("2. Average Calculator");
Console.Write("Enter your choice: ");

string choice = Console.ReadLine()!.Trim();

switch (choice)
{
    case "1":
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine()!);

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine()!.Trim();

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine()!);

        double result = op switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num1 / num2,
            _ => throw new InvalidOperationException($"Unknown operator '{op}'")
        };

        Console.WriteLine($"{num1} {op} {num2} = {result}");
        break;

    case "2":
        Console.WriteLine("Average Calculator is not implemented yet.");
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}