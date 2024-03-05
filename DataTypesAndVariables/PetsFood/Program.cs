int dogsPacks = int.Parse(Console.ReadLine());
int catsPacks = int.Parse(Console.ReadLine());
double expenses = (dogsPacks * 2.50) + (catsPacks * 4.00);

Console.WriteLine($"{expenses:F2}" + " lv.");
