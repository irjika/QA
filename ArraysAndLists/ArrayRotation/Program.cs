int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int rotations = int.Parse(Console.ReadLine());

RotateArray(numbers, rotations);

Console.WriteLine(string.Join(" ", numbers));


static void RotateArray(int[] array, int rotations)
{
    int length = array.Length;
    rotations %= length;

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
