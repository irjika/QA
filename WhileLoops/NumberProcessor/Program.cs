int number = int.Parse(Console.ReadLine());
string word = Console.ReadLine();

while (word != "End")
{
    if (word == "Inc")
    {
        number = number + 1;
        word = Console.ReadLine();
    }
    if (word == "Dec")
    {
        number = number - 1;
        word = Console.ReadLine();
    }
}
if (word == "End")
{
    Console.WriteLine(number);
}