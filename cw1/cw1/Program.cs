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