using System.ComponentModel.Design;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

//o	"Ascending" – if the numbers are in ascending order (from the smallest to the largest number)
//  "Descending" – if the numbers are in descending order (from the largest to the smallest number)//
//  	"Not sorted" – in any other case

if ((num1 != num2) && (num1 != num3) && (num2 != num3)) {
    if (num1 > num2 && num2 > num3)
    {
        Console.WriteLine("Descending");
    } else if (num1 < num2 && num2 < num3) {
        Console.WriteLine("Ascending");
} else
    {
        Console.WriteLine("Not sorted");
    }
}


