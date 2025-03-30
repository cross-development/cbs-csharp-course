using System.Text;

namespace HW_5_Task_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Option 1:");
        OptionOne();

        Console.WriteLine("Option 2:");
        OptionTwo();
    }

    static void OptionOne()
    {
        Console.Write("Введіть число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("Число парне.");
        else
            Console.WriteLine("Число непарне.");
    }

    static void OptionTwo()
    {
        Console.Write("Введіть число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if ((num & 1) == 0)
            Console.WriteLine("Число парне.");
        else
            Console.WriteLine("Число непарне.");
    }
}
