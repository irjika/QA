int n = int.Parse(Console.ReadLine());
int endLine = 1;
int i = 1;
while (i <= n)
{
    
    for (int j = 1; j <= endLine; j++)
    {
        
        Console.Write(i + " ");
        i++;
        if (i > n)
        {
            break;
        }

    }
    Console.WriteLine();
    endLine ++;
}
