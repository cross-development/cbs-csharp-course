namespace HW_9_Task_6;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[10];

        // Fill the array with arbitrary integer values.
        for (int i = 0; i < 10; i++)
        {
            array[i] = i + 1;
        }

        Console.WriteLine("Array elements in reverse order:");

        for (int i = 9; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }

        Console.ReadKey();
    }
}
