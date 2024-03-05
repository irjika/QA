// Read a sequence of incomes / expenses, until "End" is read
// Add the money to the balance (starting form 0)
// Print "Increase: {money}" or "Decrease: {money}", where value is formatted to the second decimal digit
// Finally, print the account balance, formatted to the second decimal digit
// in the following format: "Balance: {account balance}"
string num = Console.ReadLine();
double balance = 0;

while (num != "End")
{
    double money = double.Parse(num);

    if (money >= 0)
    {
        Console.WriteLine($"Increase: {money:F2}");
        balance += money;
    }
    else if (money < 0)
    {
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
        balance += money;
    }
    num = Console.ReadLine();
}
Console.WriteLine($"Balance: {balance:F2}");
