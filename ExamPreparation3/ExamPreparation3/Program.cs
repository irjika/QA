string[] digitText = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

int number = int.Parse(Console.ReadLine());

while (number > 0)
{
    int lastDigit = number % 10;
    Console.WriteLine(digitText[lastDigit]);
    number = number / 10;
}