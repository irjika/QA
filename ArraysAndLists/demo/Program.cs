Console.WriteLine("Enter the sequence of integer numbers separated by space:");
int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Console.WriteLine("Enter the number of rotations:");
int rotations = int.Parse(Console.ReadLine());

// Perform rotations
RotateArray(sequence, rotations);

// Print the resulting sequence
Console.WriteLine("Resulting Sequence:");
Console.WriteLine(string.Join(" ", sequence));
    

    static void RotateArray(int[] array, int rotations)
{
    int length = array.Length;
    rotations %= length; // Ensure that rotations do not exceed the length of the array

    // Perform left rotations
    for (int i = 0; i < rotations; i++)
    {
        int temp = array[0];
        for (int j = 0; j < length - 1; j++)
        {
            array[j] = array[j + 1];
        }
        array[length - 1] = temp;
    }
}
    



