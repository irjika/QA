int n = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine(MultipleOfEvenAndOdds(n));
static int SumOfEvens (int number)
{
    int sumEvens = 0;

    while (number > 0) 
    { 
    int digit = number % 10;
    number /= 10;
    if (digit % 2 == 0)
    {
        sumEvens += digit;
    }
}
    return sumEvens;
}

static int SumOfOdds(int number)
{
    int sumOdds = 0;
    while (number > 0)
    {
        int digit = number % 10;
        number /= 10;
        if (digit % 2 != 0)
        {
            sumOdds += digit;
        }
    }
    return sumOdds;
}
static int MultipleOfEvenAndOdds (int number)
{
    return SumOfEvens(number) * SumOfOdds(number);
}

