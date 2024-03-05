int floors = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());
string type = "";

for (int i = floors; i >= 1; i--)
{

    if (i == floors)
    {
        type = "L";
    }
    else if (i % 2 == 0)
    {
        type = "O";
    }
    else 
    {
        type = "A";
    }
    for (int j = 0; j < rooms; j++)
    {
       Console.Write($"{type}{i}{j} ");
    }
    Console.WriteLine();
}