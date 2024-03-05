int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int cleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double penPrice = pens * 5.80;
double markersPrice = markers * 7.20;
double cleanerPrice = cleaner * 1.20;
double discountPercentage = (double)discount / 100;

double materialsPrice = penPrice + markersPrice + cleanerPrice;
double percMinus = materialsPrice * discountPercentage;
double discountedPrice = materialsPrice - percMinus;

Console.WriteLine(discountedPrice);
