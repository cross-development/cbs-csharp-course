using System.Text;

namespace HW_4_Task_5;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Console.Write("Введіть слово українською (наприклад, 'сонце'): ");
        string word = Console.ReadLine().ToLower();

        if (word == "сонце")
            Console.WriteLine("Англійською: sun");
        else if (word == "дощ")
            Console.WriteLine("Англійською: rain");
        else if (word == "сніг")
            Console.WriteLine("Англійською: snow");
        else if (word == "вітер")
            Console.WriteLine("Англійською: wind");
        else if (word == "гроза")
            Console.WriteLine("Англійською: thunderstorm");
        else if (word == "хмара")
            Console.WriteLine("Англійською: cloud");
        else if (word == "мороз")
            Console.WriteLine("Англійською: frost");
        else if (word == "тепло")
            Console.WriteLine("Англійською: warm");
        else if (word == "холод")
            Console.WriteLine("Англійською: cold");
        else if (word == "буря")
            Console.WriteLine("Англійською: storm");
        else
            Console.WriteLine("Переклад не знайдено.");

        Console.ReadKey();
    }
}
