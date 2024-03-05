int chiken = int.Parse(Console.ReadLine()); // 10.35
int fish = int.Parse(Console.ReadLine()); // 12.4
int veggy = int.Parse(Console.ReadLine()); // 8.15
//desert = to 20% of the total bill (excluding delivery). 
//The delivery price is 2.50 BGN and is finally charged.
double foodPrice = (chiken * 10.35) + (fish * 12.4) + (veggy * 8.15);
double foodAmount = foodPrice + (foodPrice * 0.2);
double total = foodAmount + 2.5;
Console.WriteLine(total);
