//// Write a program that:
//•	Reads an integer number N (count of the numbers) from the console
//•	For each number (from first to the last (N)): read from the console number's value (integer number)
//•	Calculate the sum of the prime numbers only
//•	Print the calculated sum 

int n = int.Parse(Console.ReadLine());
int sum = 0;
bool isPrime = true;

for (int k = 1; k <= n; k++)
{
    int number = int.Parse(Console.ReadLine());

    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        sum++;
        Console.Write(sum);
    }
}
