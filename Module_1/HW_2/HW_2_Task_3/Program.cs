namespace HW_2_Task_3;

internal class Program
{
    static void Main(string[] args)
    {
        string str1 = "\nмій рядок 1";
        string str2 = "\tмій рядок 2";
        string str3 = "\aмій рядок 3";

        Console.WriteLine(str1);
        Console.WriteLine(str2);
        Console.WriteLine(str3);

        Console.ReadKey();

        // Висновки:
        //  \n – переносить текст на новий рядок.
        //  \t – додає табуляцію (відступ).
        //  \a – викликає звуковий сигнал системного динаміка (дзвіночок).
    }
}
