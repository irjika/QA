int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());

Console.WriteLine(MathPow(n, p));
static int MathPow (int number, int power)
{
    int result = number;
    for (int i = 2; i <= power; i++)
    {
        result *= number;
    }
    return result;
}