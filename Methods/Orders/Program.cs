string pr = Console.ReadLine();
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{SumProducts(pr, n):F2}");
static double SumProducts (string product, double number)
{
    double sum = 0;
    if (product == "coffee")
    {
        sum = number * 1.50;

    }
    else if (product == "water")
    {
        sum = number * 1.00;
    }
    else if (product == "coke")
    {
        sum = number * 1.40;
    }
    else if (product == "snacks")
    {
        sum = number * 2.00;
    }
    return sum;
}
