double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();

//"+", "-", "*", "/"
if (operation == "+")
{
    double num3 = num1 + num2;
    Console.WriteLine(num1 + " + " + num2 + " = " + String.Format("{0:0.00}", num3));
}
else if (operation == "-")
{
    double num3 = num1 - num2;
    Console.WriteLine(num1 + " - " + num2 + " = " + String.Format("{0:0.00}", num3));
}
else if (operation == "*")
{
    double num3 = num1 * num2;
    Console.WriteLine(num1 + " * " + num2 + " = " + String.Format("{0:0.00}", num3));
}
else if (operation == "/")
{
    double num3 = num1 / num2;
    Console.WriteLine(num1 + " / " + num2 + " = " + String.Format("{0:0.00}", num3));
}
