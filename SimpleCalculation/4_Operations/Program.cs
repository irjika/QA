double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
double add = n1 + n2;
double substr = n1 - n2;
double multipl = n1 * n2;
double div = n1 / n2;

Console.Write($"{n1:F2}" + " + " + $"{n2:F2}" + " = ");
Console.WriteLine($"{add:F2}");
Console.Write($"{n1:F2}" + " - " + $"{n2:F2}" + " = ");
Console.WriteLine($"{substr:F2}");
Console.Write($"{n1:F2}" + " * " + $"{n2:F2}" + " = ");
Console.WriteLine($"{multipl:F2}");
Console.Write($"{n1:F2}" + " / " + $"{n2:F2}" + " = ");
Console.WriteLine($"{div:F2}");

