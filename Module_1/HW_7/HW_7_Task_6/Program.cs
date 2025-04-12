namespace HW_7_Task_6;

internal class Program
{
    private static void Calculate(int a, int b, int c)
    {
        double avg = (a + b + c) / 3.0;

        Console.WriteLine("Average: " + avg);
    }

    private static void Main()
    {
        Console.Write("Enter first number: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int z = int.Parse(Console.ReadLine());

        Calculate(x, y, z);
    }
}
