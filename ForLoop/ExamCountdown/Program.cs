int d = int.Parse(Console.ReadLine());

for (int i = d; i >= 0 ; i--)
{
    if (i == 0)
    {
        Console.WriteLine("The exam has come");
    }
    else
    {
        Console.WriteLine(i + " days before the exam");
    }
}