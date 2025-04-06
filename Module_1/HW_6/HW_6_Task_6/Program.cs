namespace HW_6_Task_6;

internal class Program
{
    static void Main(string[] args)
    {
        int height = 4;
        int width = 7;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }
    }
}
