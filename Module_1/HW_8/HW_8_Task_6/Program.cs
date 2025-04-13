namespace HW_8_Task_6;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the first integer: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter the third integer: ");
        int third = int.Parse(Console.ReadLine());

        var results = Calculate(first, second, third);

        Console.WriteLine("Result for the first value divided by 5: " + results.Item1);
        Console.WriteLine("Result for the second value divided by 5: " + results.Item2);
        Console.WriteLine("Result for the third value divided by 5: " + results.Item3);
    }

    static (double, double, double) Calculate(int a, int b, int c)
    {
        double resultA = a / 5.0;
        double resultB = b / 5.0;
        double resultC = c / 5.0;

        return (resultA, resultB, resultC);
    }
}
