Console.WriteLine("Select a program:");
Console.WriteLine("1. Calculator");
Console.WriteLine("2. Average Calculator");
Console.WriteLine("3. Maximum Calculator");
Console.WriteLine("4. Minimum Calculator");
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
        double sum = 0;
        int count = 0;

        Console.WriteLine("Enter numbers one by one.");
        Console.WriteLine("Enter '.' to calculate the average.");

        while (true)
        {
            Console.Write("Enter a number (or '.'): ");
            string input = Console.ReadLine()!.Trim();

            if (input == ".")
            {
                break;
            }

            if (double.TryParse(input, out double number))
            {
                sum += number;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid number. Please try again.");
            }
        }

        if (count > 0)
        {
            double average = sum / count;
            Console.WriteLine($"Average: {average}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        break;

    case "3":
        double? max = null;

        Console.WriteLine("Enter numbers one by one.");
        Console.WriteLine("Enter '.' to calculate the maximum.");

        while (true)
        {
            Console.Write("Enter a number (or '.'): ");
            string input = Console.ReadLine()!.Trim();

            if (input == ".")
            {
                break;
            }

            if (double.TryParse(input, out double number))
            {
                if (max is null || number > max.Value)
                {
                    max = number;
                }
            }
            else
            {
                Console.WriteLine("Invalid number. Please try again.");
            }
        }

        if (max is not null)
        {
            Console.WriteLine($"Maximum: {max.Value}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        break;

    case "4":
        double? min = null;

        Console.WriteLine("Enter numbers one by one.");
        Console.WriteLine("Enter '.' to calculate the minimum.");

        while (true)
        {
            Console.Write("Enter a number (or '.'): ");
            string input = Console.ReadLine()!.Trim();

            if (input == ".")
            {
                break;
            }

            if (double.TryParse(input, out double number))
            {
                if (min is null || number < min.Value)
                {
                    min = number;
                }
            }
            else
            {
                Console.WriteLine("Invalid number. Please try again.");
            }
        }

        if (min is not null)
        {
            Console.WriteLine($"Minimum: {min.Value}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}