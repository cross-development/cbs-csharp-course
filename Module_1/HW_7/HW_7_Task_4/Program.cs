namespace HW_7_Task_4;

internal class Program
{
    // Method to check the sign of the number
    private static void CheckSign(int number)
    {
        switch (number)
        {
            case > 0:
                Console.WriteLine("The number is positive.");
                break;
            case < 0:
                Console.WriteLine("The number is negative.");
                break;
            default:
                Console.WriteLine("Zero is neither positive nor negative.");
                break;
        }
    }

    // Method to check whether the number is prime
    private static void CheckPrime(int number)
    {
        if (number < 2)
        {
            Console.WriteLine("The number is not prime (numbers less than 2 are not considered prime).");
            return;
        }

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i != 0) continue;
            isPrime = false;
            break;
        }
        Console.WriteLine(isPrime ? "The number is prime." : "The number is not prime.");
    }

    // Method to check divisibility by 2, 5, 3, 6, and 9
    private static void CheckDivisibility(int number)
    {
        Console.WriteLine("Divisibility check:");
        Console.WriteLine("Divisible by 2: " + (number % 2 == 0 ? "Divides evenly" : "Divides with remainder"));
        Console.WriteLine("Divisible by 5: " + (number % 5 == 0 ? "Divides evenly" : "Divides with remainder"));
        Console.WriteLine("Divisible by 3: " + (number % 3 == 0 ? "Divides evenly" : "Divides with remainder"));
        Console.WriteLine("Divisible by 6: " + (number % 6 == 0 ? "Divides evenly" : "Divides with remainder"));
        Console.WriteLine("Divisible by 9: " + (number % 9 == 0 ? "Divides evenly" : "Divides with remainder"));
    }

    private static void Main()
    {
        Console.Write("Enter a number: ");

        int number = int.Parse(Console.ReadLine());

        CheckSign(number);
        CheckPrime(number);
        CheckDivisibility(number);
    }
}
