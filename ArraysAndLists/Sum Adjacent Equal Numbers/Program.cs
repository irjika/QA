﻿List<int> numbers = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

while (true)
{
    bool hasEqual = false;
    for (int i = 0; i < numbers.Count - 1; i++)
    {
        int currentNum = numbers[i];
        int nextNum = numbers[i + 1];

        if (currentNum == nextNum)
        {
            int sum = currentNum + nextNum;
            numbers.RemoveAt(i);
            numbers.RemoveAt(i);
            numbers.Insert(i, sum);
            hasEqual = true;
            break;

        }
    }
    if (!hasEqual)
    {
        break;
    }
}

Console.WriteLine(string.Join(" ", numbers));
