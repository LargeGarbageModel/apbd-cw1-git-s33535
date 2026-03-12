// Display the available program options to the user.
Console.WriteLine("Select a program:");
Console.WriteLine("1. Calculator");
Console.WriteLine("2. Average Calculator");
Console.Write("Enter your choice: ");

// Read the user's menu selection and remove extra whitespace.
string choice = Console.ReadLine()!.Trim();

// Execute the selected program based on the user's choice.
switch (choice)
{
    case "1":
        // Ask for the first number and convert the input to a double.
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine()!);

        // Ask for the math operator.
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine()!.Trim();

        // Ask for the second number and convert the input to a double.
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine()!);

        // Perform the selected calculation using a switch expression.
        double result = op switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num1 / num2,
            _ => throw new InvalidOperationException($"Unknown operator '{op}'")
        };

        // Display the full calculation and its result.
        Console.WriteLine($"{num1} {op} {num2} = {result}");
        break;

    case "2":
        // Initialize variables to store the running total and number count.
        double sum = 0;
        int count = 0;

        // Explain how the average calculator works.
        Console.WriteLine("Enter numbers one by one.");
        Console.WriteLine("Enter '.' to calculate the average.");

        // Keep reading input until the user enters a period.
        while (true)
        {
            Console.Write("Enter a number (or '.'): ");
            string input = Console.ReadLine()!.Trim();

            // Stop collecting numbers when the user enters ".".
            if (input == ".")
            {
                break;
            }

            // If the input is a valid number, add it to the sum and increase the count.
            if (double.TryParse(input, out double number))
            {
                sum += number;
                count++;
            }
            else
            {
                // Show an error message for invalid input.
                Console.WriteLine("Invalid number. Please try again.");
            }
        }

        // Calculate and display the average if at least one number was entered.
        if (count > 0)
        {
            double average = sum / count;
            Console.WriteLine($"Average: {average}");
        }
        // Otherwise, display a message indicating no numbers were entered.
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        break;
    // Handle invalid choices by displaying an error message.
    default:
        Console.WriteLine("Invalid choice.");
        break;
}