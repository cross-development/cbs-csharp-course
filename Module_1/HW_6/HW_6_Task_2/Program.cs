namespace HW_6_Task_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the number B (B > A): ");
        int b = int.Parse(Console.ReadLine());

        int sum = 0;

        Console.WriteLine("Odd numbers between A and B:");
        for (int i = a + 1; i < b; i++)
        {
            sum += i;

            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Sum of numbers between A and B: " + sum);
    }
}
