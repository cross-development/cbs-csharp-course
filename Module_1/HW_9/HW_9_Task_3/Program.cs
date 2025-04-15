namespace HW_9_Task_3;

internal class Program
{
    // Method to reverse the array
    private static int[] MyReverse(int[] array)
    {
        int n = array.Length;
        int[] reversed = new int[n];

        for (int i = 0; i < n; i++)
        {
            reversed[i] = array[n - 1 - i];
        }

        return reversed;
    }

    // Method to return a subarray starting at index with given count.
    // If count exceeds the available elements, fill the rest with 1's.
    private static int[] SubArray(int[] array, int index, int count)
    {
        int[] sub = new int[count];
        int i;

        // Copy available elements
        for (i = 0; i < count && (index + i) < array.Length; i++)
        {
            sub[i] = array[index + i];
        }

        // Fill remaining with ones if needed
        for (; i < count; i++)
        {
            sub[i] = 1;
        }

        return sub;
    }

    private static void Main(string[] args)
    {
        int[] array = { 10, 20, 30, 40, 50, 60 };

        int[] reversedArray = MyReverse(array);

        Console.WriteLine("Reversed array:");

        for (int i = 0; i < reversedArray.Length; i++)
        {
            Console.Write(reversedArray[i] + " ");
        }

        Console.WriteLine();

        int[] subArray = SubArray(array, 3, 5);

        Console.WriteLine("Sub array (starting at index 3, count = 5):");

        for (int i = 0; i < subArray.Length; i++)
        {
            Console.Write(subArray[i] + " ");
        }

        Console.ReadKey();
    }
}
