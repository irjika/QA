int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int power = 1;
int i = 1;
for (i = 1; i <= p; i++)
{
    power = n * power;
}
Console.WriteLine(power);