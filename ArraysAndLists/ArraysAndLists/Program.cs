int[] aNumbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
//List <int> outputNumbers = new List<int>();

//int outputNumbersLenght = aNumbers.Length % 2 == 0 ?
//aNumbers.Length / 2 : aNumbers.Length + 1;

int outputNumbersLenght = aNumbers.Length / 2;

if (aNumbers.Length % 2 != 0)
{
    outputNumbersLenght++;
}
int [] outputNumbers = new int[outputNumbersLenght];

for (int i = 0; i < outputNumbersLenght; i++)
{
    if (aNumbers.Length % 2 != 0 && i == outputNumbersLenght - 1)
    {
        outputNumbers[i] = aNumbers[i];

    }
    else
    {
        int elementA = aNumbers[i];
        int elementB = aNumbers[aNumbers.Length - 1 - i];
        outputNumbers[i] = elementA + elementB;
    }
}
Console.WriteLine(string.Join(" ", outputNumbers));