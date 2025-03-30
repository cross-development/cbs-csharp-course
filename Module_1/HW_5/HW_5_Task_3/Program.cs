namespace HW_5_Task_3;

internal class Program
{
    static void Main(string[] args)
    {
        int x = 5, y = 10, z = 15;

        x += y >> x++ * z;
        Console.WriteLine($"x = {x}");

        z = ++x & y * 5;
        Console.WriteLine($"z = {z}");

        y /= x + 5 | z;
        Console.WriteLine($"y = {y}");

        z = x++ & y * 5;
        Console.WriteLine($"z = {z}");

        x = y << x++ ^ z;
        Console.WriteLine($"x = {x}");
    }
}
