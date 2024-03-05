int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i < n; i++)
{
Console.Write(i + "+");
    sum += i;
}
Console.Write(n);
sum = sum + n;
Console.WriteLine("=" + sum);
    