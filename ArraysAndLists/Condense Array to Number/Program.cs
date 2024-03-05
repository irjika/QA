int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

while (numbers.Length > 1)
{
    int[] condArr = new int[numbers.Length - 1];

    for (int i = 0; i < condArr.Length; i++)
    {
        condArr[i] = numbers[i] + numbers[i + 1];
    }

    numbers = condArr;
}

Console.WriteLine(numbers[0]);