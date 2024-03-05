int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int n = int.Parse(Console.ReadLine());

if (int.TryParse(Console.ReadLine(), out n))
{
    
    Console.WriteLine($"{string.Join(" ", GetNumbersGreaterThanN(numbers, n))}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer for N.");
}
    

    static int[] GetNumbersGreaterThanN(int[] numbers, int n)
{
    // Use LINQ to filter numbers greater than N
    return Array.FindAll(numbers, num => num > n);
}

