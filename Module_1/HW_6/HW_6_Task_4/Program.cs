namespace HW_6_Task_4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number of clients: ");

        int n = int.Parse(Console.ReadLine());
        int result = 1;
        int i = 1;

        do
        {
            result *= i;
            i++;
        } while (i <= n);

        Console.WriteLine("Number of possible routes: " + result);
    }
}
