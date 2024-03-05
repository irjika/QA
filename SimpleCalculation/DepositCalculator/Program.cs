double amount = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double annualRate = double.Parse(Console.ReadLine());
double accumulatedInterest = amount * (annualRate / 100);
double monthInterest = accumulatedInterest / 12;
double totalAmount = amount + months * monthInterest;

Console.WriteLine($"{totalAmount:F2}");

