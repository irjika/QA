string dring = Console.ReadLine();
string sugar = Console.ReadLine();
if (dring == "coffee")
{
    if (sugar == "sugar")
    {
        Console.Write("Final price: $1.40");
    }
    else if (sugar == "no")
    {
        Console.Write("Final price: $1.00");
    }
}
else if (dring == "tea")
{
    if (sugar == "sugar")
    {
        Console.Write("Final price: $1.00");
    }
    else if (sugar == "no")
    {
        Console.Write("Final price: $0.60");
    }
}