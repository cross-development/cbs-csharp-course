namespace HW_3_Task_5;

internal class Program
{
    static void Main(string[] args)
    {
        // int uberflu?;      // Некоректне (символ '?' не допускається)
        int _Identifier = 10; // Коректне (починається з '_')
        int Identifier = 20;  // Коректне (звичайне ім'я)
        // int &myVar;        // Некоректне ('&' не допускається)
        int myVariab1le = 30; // Коректне (латинські букви та цифри)

        Console.WriteLine($"_Identifier: {_Identifier}, Identifier: {Identifier}, myVariab1le: {myVariab1le}");
    }
}
