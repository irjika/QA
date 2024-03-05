double bathWidth = double.Parse(Console.ReadLine());
double bathHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());
double bath = bathWidth * bathHeight;
double tile = tileWidth * tileHeight;
double surplus = bath * 1.1;
double tileNeeded = (surplus / tile);
double result = Math.Round(tileNeeded);

Console.WriteLine(result);

