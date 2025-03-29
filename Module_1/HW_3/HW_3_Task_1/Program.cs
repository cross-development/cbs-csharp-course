namespace HW_3_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            x += y - x++ * z;
            Console.WriteLine($"Step 1: x = {x}");

            z = --x - y * 5;
            Console.WriteLine($"Step 2: z = {z}");

            y /= x + 5 % z;
            Console.WriteLine($"Step 3: y = {y}");

            z = x++ + y * 5;
            Console.WriteLine($"Step 4: z = {z}");

            x = y - x++ * z;
            Console.WriteLine($"Step 5: x = {x}");
        }
    }
}
