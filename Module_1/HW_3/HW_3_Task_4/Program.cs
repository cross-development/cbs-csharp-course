namespace HW_3_Task_4;

internal class Program
{
    static void Main(string[] args)
    {
        const double pi = 3.141592653;
        double r = 5.0, h = 10.0;

        double volume = pi * r * r * h;
        double surfaceArea = 2 * pi * r * (r + h);

        Console.WriteLine($"Cylinder Volume: {volume}");
        Console.WriteLine($"Cylinder Surface Area: {surfaceArea}");
    }
}
