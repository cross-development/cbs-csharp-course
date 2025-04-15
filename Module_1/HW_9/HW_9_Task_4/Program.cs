namespace HW_9_Task_4;

internal class Program
{
    // Method to increase the length of an array by 1 (without altering the content order)
    private static int[] IncreaseLength(int[] array)
    {
        int n = array.Length;
        int[] newArray = new int[n + 1];

        for (int i = 0; i < n; i++)
        {
            newArray[i] = array[i];
        }

        return newArray;
    }

    // Method to add a value to the beginning of the array.
    // The new value is placed at index 0 and the original array is copied starting from index 1.
    private static int[] AddToStart(int[] array, int value)
    {
        int n = array.Length;
        int[] newArray = new int[n + 1];
        newArray[0] = value;

        for (int i = 0; i < n; i++)
        {
            newArray[i + 1] = array[i];
        }

        return newArray;
    }

    private static void Main(string[] args)
    {
        int[] original = [5, 10, 15, 20];

        int[] increasedArray = IncreaseLength(original);

        Console.WriteLine("Array after increasing length by 1:");

        for (int i = 0; i < increasedArray.Length; i++)
        {
            Console.Write(increasedArray[i] + " ");
        }

        Console.WriteLine();

        int valueToAdd = 99;
        int[] newArray = AddToStart(original, valueToAdd);

        Console.WriteLine("Array after adding value at the start:");

        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write(newArray[i] + " ");
        }

        Console.ReadKey();
    }
}
