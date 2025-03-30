using System.Text;

namespace HW_5_Task_6;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Console.Write("Введіть число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0 && (num & (num - 1)) == 0)
            Console.WriteLine("Число є ступенем двійки.");
        else
            Console.WriteLine("Число НЕ є ступенем двійки.");
    }
}
