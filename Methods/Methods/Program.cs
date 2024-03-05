int n = int.Parse(Console.ReadLine());

CheckNumber(n);
static void CheckNumber (int number)
{
    if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
    else 
    {
        Console.WriteLine($"The number {number} is zero.");
    }
}

