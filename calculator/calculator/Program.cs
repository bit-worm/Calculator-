System.Console.WriteLine("Welcome to my calculator program.");

Console.Write("Enter first number: ");
decimal num1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter second number: ");
decimal num2 = Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine();
string? choice;

Console.Write("Choose an operation (Addition-A, Subtruction-S, Division-D, Multiplication-M): ");
choice = Convert.ToString(Console.ReadLine());
Console.WriteLine();

switch (choice.ToLower())
{
    case "a":
        System.Console.WriteLine($"     Sum: {num1.ToString()} + {num2.ToString()} = {num1 + num2:N4}");
        break;
    case "s":
        System.Console.WriteLine($"     Difference: {num1.ToString()} - {num2.ToString()} = {num1 - num2:N4}");
        break;
    case "d":
        while (num2 == 0)
        {
            System.Console.WriteLine("Cannot divide by zero");
            Console.Write("Enter second number: ");
            num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
        }
        System.Console.WriteLine($"     Quotient: {num1.ToString()} / {num2.ToString()} = {num1 / num2:N4}");
        break;
    case "m":
        System.Console.WriteLine($"     Product: {num1.ToString()} * {num2.ToString()} = {num1 * num2:N4}");
        break;
}
Console.WriteLine();
System.Console.WriteLine("Thank you for using my program.\n");
Console.WriteLine("press any key to exit...");

Console.ReadKey(true);