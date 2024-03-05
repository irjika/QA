﻿List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int[] bombArgs = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int bombNumber = bombArgs[0];
int bombPower = bombArgs[1];

for (int i = 0; i < numbers.Count; i++)
{
    int currentNumber = numbers[i];
    if (currentNumber == bombNumber)
    {

        int leftIndex = i - bombPower;
        if (leftIndex < 0)
        {
            leftIndex = 0;
        }
        int rightIndex = i + bombPower;
        if (rightIndex > numbers.Count - 1)
        {
            rightIndex = numbers.Count - 1;
        }

        int numbersToDetonate = rightIndex - leftIndex + 1;

        for (int j = 0; j < numbersToDetonate; j++)
        {
            numbers.RemoveAt(leftIndex);
        }
        i = leftIndex - 1;
    }
}

Console.WriteLine(GetSumOfListItems(numbers));

static int GetSumOfListItems(List<int> numbers)
{
    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}
