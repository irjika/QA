int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

int result = n1 * n2 * n3;

if (result < 0)
{
    Console.WriteLine("negative");
}
else if (result == 0)
{
    Console.WriteLine("zero");
}
else
{
    Console.WriteLine("positive");
}