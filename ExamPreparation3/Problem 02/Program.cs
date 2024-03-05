int[] number = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int n = int.Parse(Console.ReadLine());
int arrLenght = number.Length;
int sum = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = number[arrLenght - 1 - i];
    sum += currentNumber;
}

double lastElementAvg = (double)sum / n; // Cast to double

Console.WriteLine($"{lastElementAvg:F2}");

