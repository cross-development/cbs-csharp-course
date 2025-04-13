namespace HW_8_Task_3;

internal class Program
{
    static int Factorial(int n)
    {
        return n <= 1 ? 1 : n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of clients: ");

        int n;

        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        int routes = Factorial(n);

        Console.WriteLine("Number of possible delivery routes: " + routes);


        //Note:
        //Recursion is not recommended for large values of n due to the risk of stack overflow.
        //Each recursive call uses memory, and deep recursion may cause program crashes.
    }
}
