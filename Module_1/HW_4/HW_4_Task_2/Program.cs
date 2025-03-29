namespace HW_4_Task_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number (operand1): ");
        double operand1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number (operand2): ");
        double operand2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an arithmetic operation (+, -, *, /): ");
        string sign = Console.ReadLine();

        switch (sign)
        {
            case "+":
                Console.WriteLine($"Result: {operand1 + operand2}");
                break;
            case "-":
                Console.WriteLine($"Result: {operand1 - operand2}");
                break;
            case "*":
                Console.WriteLine($"Result: {operand1 * operand2}");
                break;
            case "/":
                if (operand2 != 0)
                    Console.WriteLine($"Result: {operand1 / operand2}");
                else
                    Console.WriteLine("Error: Division by zero is not allowed.");
                break;
            default:
                Console.WriteLine("Error: Invalid operation.");
                break;
        }

        Console.ReadKey();
    }
}
