namespace HW_4_Task_3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number (0-100): ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 0 && number <= 14)
            Console.WriteLine("The number is in the range [0 - 14].");
        else if (number >= 15 && number <= 35)
            Console.WriteLine("The number is in the range [15 - 35].");
        else if (number >= 36 && number <= 50)
            Console.WriteLine("The number is in the range [36 - 50].");
        else if (number >= 51 && number <= 100)
            Console.WriteLine("The number is in the range [51 - 100].");
        else
            Console.WriteLine("The number is out of range.");

        Console.ReadKey();
    }
}
