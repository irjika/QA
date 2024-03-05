double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3 = double.Parse(Console.ReadLine());

double product = num1 * num2 * num3;

if  (product == 0)
{
    Console.WriteLine("zero");
}
else  if (product > 0)
{
    Console.WriteLine("positive");
}
else if (product < 0)
{
    Console.WriteLine("negative");
}