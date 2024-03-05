int n = int.Parse(Console.ReadLine());
int sumVowels = 0;
for (int i = 1; i <=n; i++)
 
{
    var nextSymbol = Console.ReadLine();
    switch (nextSymbol)
    {
        case "a":
            sumVowels += 1;
            break;
        case "e":
            sumVowels += 2;
            break;
        case "i":
            sumVowels += 3;
            break;
        case "o":
            sumVowels += 4;
            break;
        case "u":
            sumVowels += 5;
            break;
    }
}
Console.WriteLine(sumVowels);