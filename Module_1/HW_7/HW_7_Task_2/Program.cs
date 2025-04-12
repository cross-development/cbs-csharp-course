namespace HW_7_Task_2;

internal class Program
{
    private static void Add(int a, int b)
    {
        Console.WriteLine($"Result: {a + b}");
    }

    private static void Sub(int a, int b)
    {
        Console.WriteLine($"Result: {a - b}");
    }

    private static void Mul(int a, int b)
    {
        Console.WriteLine($"Result: {a * b}");
    }

    private static void Div(int a, int b)
    {
        Console.WriteLine(b == 0 ? "Error: Division by zero." : $"Result: {(double)a / b}");
    }

    private static void Main()
    {
        Console.Write("Enter first number: ");
        int operand1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int operand2 = int.Parse(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        string sign = Console.ReadLine();

        switch (sign)
        {
            case "+":
                Add(operand1, operand2);
                break;
            case "-":
                Sub(operand1, operand2);
                break;
            case "*":
                Mul(operand1, operand2);
                break;
            case "/":
                Div(operand1, operand2);
                break;
            default:
                Console.WriteLine("Unknown operation.");
                break;
        }
    }
}
