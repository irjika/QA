string text = Console.ReadLine();

int sumUpper = 0;
int sumLower = 0;
int sumSpace = 0;


foreach (char ch in text)
{
    if (char.IsUpper(ch))
    {
        sumUpper++;
    }
    else if (char.IsLower(ch))
    {
        sumLower++;
    }
    else if (char.IsWhiteSpace(ch))
    {
        sumSpace++;
    }
}

Console.WriteLine(sumUpper);
Console.WriteLine(sumLower);
Console.WriteLine(sumSpace);

