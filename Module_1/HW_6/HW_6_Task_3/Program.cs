namespace HW_6_Task_3;

internal class Program
{
    static void Main(string[] args)
    {
        // Прямокутник
        Console.WriteLine("Rectangle:");

        for (int i = 0; i < 5; i++) // Висота
        {
            for (int j = 0; j < 10; j++) // Ширина
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

        // Прямокутний трикутник
        Console.WriteLine("\nRectilinear triangle:");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

        // Рівносторонній трикутник
        Console.WriteLine("\nEquilateral triangle:");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5 - i; j > 0; j--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

        // Ромб
        Console.WriteLine("\nRhombus:");

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 5 - i; j > 0; j--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 5 - i; j > 0; j--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }
    }
}
