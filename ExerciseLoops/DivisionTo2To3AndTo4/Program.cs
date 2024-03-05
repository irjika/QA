int n = int.Parse(Console.ReadLine());
int divisibleBy2 = 0, divisibleBy3 = 0, divisibleBy4 = 0;

for (int i = 1; i <= 3; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0)
        divisibleBy2++;

    if (number % 3 == 0)
        divisibleBy3++;

    if (number % 4 == 0)
        divisibleBy4++;
}      

        double percentDivisibleBy2 = (double)divisibleBy2 / n * 100;
        double percentDivisibleBy3 = (double)divisibleBy3 / n * 100;
        double percentDivisibleBy4 = (double)divisibleBy4 / n * 100;

        Console.WriteLine($"{percentDivisibleBy2:F2}%");
        Console.WriteLine($"{percentDivisibleBy3:F2}%");
        Console.WriteLine($"{percentDivisibleBy4:F2}%");