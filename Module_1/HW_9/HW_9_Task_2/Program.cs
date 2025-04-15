namespace HW_9_Task_2;


internal class Program
{
    private static void Main(string[] args)
    {
        // Get random array size
        int size = GetRandomArraySize();

        // Create new array with random numbers and size
        int[] array = CreateNewArrayOfSize(size);

        // Compute maximum, minimum, sum and arithmetic mean.
        ComputeAndDisplayArrayStats(array, size);

        // Display all odd values
        DisplayArrayOddValues(array, size);

        Console.ReadKey();
    }

    private static int GetRandomArraySize()
    {
        Console.Write("Enter the size of the array (N): ");

        int size = int.Parse(Console.ReadLine());

        return size;
    }

    private static int[] CreateNewArrayOfSize(int size)
    {
        int[] array = new int[size];

        Random rnd = new Random();

        // Fill array with random integer values
        for (int i = 0; i < size; i++)
        {
            array[i] = rnd.Next(0, 101);
        }

        return array;
    }

    private static void ComputeAndDisplayArrayStats(int[] array, int size)
    {
        int max = array[0];
        int min = array[0];
        int sum = 0;

        for (int i = 0; i < size; i++)
        {
            if (array[i] > max)
                max = array[i];

            if (array[i] < min)
                min = array[i];

            sum += array[i];
        }

        double average = (double)sum / size;

        Console.WriteLine("\nArray elements:");

        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Maximum value: " + max);
        Console.WriteLine("Minimum value: " + min);
        Console.WriteLine("Total sum: " + sum);
        Console.WriteLine("Arithmetic mean: " + average);
    }

    private static void DisplayArrayOddValues(int[] array, int size)
    {
        Console.WriteLine("Odd values in the array:");

        for (int i = 0; i < size; i++)
        {
            if (array[i] % 2 != 0)
                Console.Write(array[i] + " ");
        }
    }
}
