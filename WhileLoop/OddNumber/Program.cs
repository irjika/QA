﻿int number = int.Parse(Console.ReadLine());

while (number % 2 == 0)
{
    number = int.Parse(Console.ReadLine());
}
if (number % 2 != 0)
{
    Console.WriteLine(number);
}