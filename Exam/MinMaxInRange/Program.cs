int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int n = int.Parse(Console.ReadLine());

int m = int.Parse(Console.ReadLine());

int min = int.MaxValue;
int max = int.MinValue;

for (int i = n; i <= m; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine(min + max);
