using System.Diagnostics.CodeAnalysis;

bool noMagicNumbers = true;

int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    int currentNum = i;
    int sumDigits = 0;
    bool isAllDigitsPrime = true;

    while (currentNum > 0)
    {
        int digit = currentNum % 10;
        currentNum = currentNum / 10;
        sumDigits += digit;

        if (digit !=2 && digit !=3 && digit != 5 && digit != 7)
        {
            isAllDigitsPrime = false;
        }
    }
    if (isAllDigitsPrime && sumDigits % 2 == 0)
    {
        Console.Write(i + " ");
        noMagicNumbers = false;
    }
}
if (noMagicNumbers)
{
    Console.WriteLine("no");
}
