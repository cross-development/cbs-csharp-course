using System.Text;

namespace HW_5_Task_4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Console.Write("Введіть зарплату: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Введіть вислугу років: ");
        int years = int.Parse(Console.ReadLine());

        double bonusPercentage = years switch
        {
            < 5 => 0.1,
            < 10 => 0.15,
            < 15 => 0.25,
            < 20 => 0.35,
            < 25 => 0.45,
            _ => 0.5
        };

        double totalBonus = salary * bonusPercentage;
        Console.WriteLine($"Ваша премія: {totalBonus}");
    }
}
