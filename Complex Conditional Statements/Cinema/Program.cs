string movie = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());
double price = 0;

//Type of the movie will be one of the following: "Premiere", "Normal" and "Discount"
//Prints the total price for all seats formatted to the 2nd digit after the decimal point:
// premi - 12; normal - 7.50; discount - 5;

if (movie == "Premiere")
{
    price = (rows * seats) * 12;
    Console.WriteLine(Math.Round(price, 2));
} else if (movie == "Normal") {
    price = (rows * seats) * 7.50;
    Console.WriteLine(Math.Round(price, 2));
}
else if (movie == "Discount")
{
    price = (rows * seats) * 5;
    Console.WriteLine(Math.Round(price, 2));
}
