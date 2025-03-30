using System.Text;

namespace HW_5_Task_7;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        bool a = true, b = false;

        bool original = a | b;
        bool transformed = !(!a & !b);

        Console.WriteLine($"Оригінальний вираз: {original}");
        Console.WriteLine($"Перетворений вираз: {transformed}");
    }
}
