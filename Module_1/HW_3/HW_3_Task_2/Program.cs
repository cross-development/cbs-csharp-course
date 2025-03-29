namespace HW_3_Task_2;

internal class Program
{
    static void Main(string[] args)
    {
        int a = 10, b = 15, c = 20;
        double average = (a + b + c) / 3.0;

        Console.WriteLine($"Average: {average}");

        // Проблема: якщо використовувати int, результат буде округлено вниз.
        // Кращий тип: double, щоб уникнути втрати точності при діленні.
    }
}
