double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());
double tomatos = tomatoPrice * tomatoQuantity;
double cucumbers = cucumberPrice * cucumberQuantity;
double total = tomatos + cucumbers;

//Console.WriteLine($"{tomatos:F2}");
//Console.WriteLine($"{cucumbers:F2}");
Console.WriteLine($"{total:F2}");

//Tomatoes: 42.50 * 3.30 = 140.25
//Cucumbers: 60.80 * 1.80 = 109.44
//Total cost: 140.25 + 109.44 = 249.69

