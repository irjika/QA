int nylonM2 = int.Parse(Console.ReadLine()); // 1.50 + 2
int paintLit = int.Parse(Console.ReadLine()); // 14.50 + 10%
int thinnerLit = int.Parse(Console.ReadLine()); // 5.00 + 0,40 for bags
int hoursWorking = int.Parse(Console.ReadLine());
double bags = 0.4;
// The amount paid to the craftsmen for 1 hour of work is equal to
// 30% of the sum of all material costs

double nylonPrice = (nylonM2 + 2) * 1.50;
double paintPrice = (paintLit * 1.1) * 14.50;
double thinnerPrice = (thinnerLit * 5);
double totalMaterials = nylonPrice + paintPrice + thinnerPrice + bags;
double workerPrice = hoursWorking * (totalMaterials * 0.3);

Console.WriteLine(totalMaterials + workerPrice);