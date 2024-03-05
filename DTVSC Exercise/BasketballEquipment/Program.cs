int annualFee = int.Parse(Console.ReadLine());
//•	Basketball sneakers – their price is 40% less than the fee for one year
//Basketball team – its price is 20% cheaper than that of sneakers
//Basketball – its price is 1 / 4 of the price of the basketball team
//Basketball accessories – their price is 1 / 5 of the price of the basketball
double sneakers = annualFee * 0.6;
double suit = sneakers * 0.8;
double ball = suit * 0.25;
double accessories = ball * 0.2;
double total = annualFee + accessories + ball + suit + sneakers;
Console.WriteLine(total);

