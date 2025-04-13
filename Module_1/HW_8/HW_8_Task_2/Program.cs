namespace HW_8_Task_2;
internal class Program
{
    static int remaining = 700;

    static void MakePayment()
    {
        if (remaining <= 0)
        {
            if (remaining == 0)
                Console.WriteLine("Loan fully repaid. No remaining debt.");
            else
                Console.WriteLine("Loan fully repaid. Overpayment: " + Math.Abs(remaining) + " UAH.");
            return;
        }

        Console.Write("Enter payment amount: ");

        int payment;

        if (!int.TryParse(Console.ReadLine(), out payment))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            MakePayment(); 
            return;
        }

        remaining -= payment;

        if (remaining > 0)
        {
            Console.WriteLine("Remaining debt: " + remaining + " UAH.");
            MakePayment(); 
        }
        else if (remaining == 0)
        {
            Console.WriteLine("Loan fully repaid. No remaining debt.");
        }
        else 
        {
            Console.WriteLine("Loan fully repaid. Overpayment: " + Math.Abs(remaining) + " UAH.");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Total loan amount: 700 UAH.");
        MakePayment();
    }
}

