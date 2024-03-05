// If the figure is square: read one floating-point number, representing side of the square
//If the figure is rectangle: read two floating-point numbers,
//representing width and length of the rectangle
//If the figure is circle: read one floating-point number,
//representing radius of the circle
//Calculate area of the given figure
//If the figure is square: area = side * side
//If the figure is rectangle: area = width * length
//If the figure is circle: area = pi * radius * radius
//Prints the calculated area, formatted to the 2nd decimal

string figure = Console.ReadLine();
if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    double area = side * side;
    Console.WriteLine($"{area:F2}");
} 
else  if (figure == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    double area = sideA * sideB;
    Console.WriteLine($"{area:F2}");
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * radius * radius;
    Console.WriteLine($"{area:F2}");
}