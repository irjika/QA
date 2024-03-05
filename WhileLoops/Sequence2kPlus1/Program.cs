int stop = int.Parse(Console.ReadLine());
int first = 1;

while (stop > first)
{
    Console.WriteLine(first);
    first = (first * 2) + 1;    
}
