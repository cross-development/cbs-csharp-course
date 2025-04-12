namespace HW_7_Task_3;

internal class Program
{
    private static double Convert(double amount, double rate)
    {
        return amount * rate;
    }

    private static void Main()
    {
        Console.Write("Enter amount: ");
        double amount = double.Parse(Console.ReadLine());

        Console.Write("Enter exchange rate: ");
        double rate = double.Parse(Console.ReadLine());

        double result = Convert(amount, rate);
        Console.WriteLine("Converted amount: " + result);
    }
}
