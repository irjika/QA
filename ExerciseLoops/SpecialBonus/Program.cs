//Write a program to apply a 20% bonus for certain number:
//Reads an integer number from the console: the "stop number"
int stopNumber = int.Parse(Console.ReadLine());
int tempNum = 0;
int lastNum = tempNum;
//Keep reading integers until it finds the stop number:
while (tempNum != stopNumber)
{
    tempNum = int.Parse(Console.ReadLine());
    

    if (tempNum == stopNumber)
    {
        Console.WriteLine(lastNum * 1.2);
    }
    lastNum = tempNum;
}



