int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

int volumeCM = lenght * width * height;
double volumeLitres = (double)volumeCM / 1000;
double water = volumeLitres - (volumeLitres*(percentage / 100));

Console.WriteLine($"{water:F2}");