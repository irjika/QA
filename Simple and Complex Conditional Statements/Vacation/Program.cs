using System.ComponentModel;

string season = Console.ReadLine();
string accommodation = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double money = 0;

//Season will be one of the following: "Spring", "Summer", "Autumn" and "Winter"
//Accommodation type will be one of the following: "Hotel" and "Camping
// sp/h - 30, sp/c - 10, disc - 20%
// sum/h - 50, sum/c - 30, disc - 0%
//au/h - 20; au/c - 15; disc - 30%;
//win/h - 40; wi/c -10; disc - 10%;

if (season == "Spring") {
    if (accommodation == "Hotel") {
        money = (30 * days) * 0.8;
        Console.WriteLine(money.ToString("0.00"));
    } else if (accommodation == "Camping") {
        money = (10 * days) * 0.8;
        Console.WriteLine(money.ToString("0.00"));
    }
}
else if (season == "Summer") {
    if (accommodation == "Hotel") {
        money = (50 * days);
        Console.WriteLine(money.ToString("0.00"));
    }
    else if (accommodation == "Camping")
    {
        money = (30 * days);
        Console.WriteLine(money.ToString("0.00"));
    }
}
else if (season == "Autumn") {
    if (accommodation == "Hotel") {
        money = (20 * days) * 0.7;
        Console.WriteLine(money.ToString("0.00"));
    }
    else if (accommodation == "Camping") {
        money = (15 * days) * 0.7;
        Console.WriteLine(money.ToString("0.00"));
    }
}
else if (season == "Winter") {
    if (accommodation == "Hotel") {
        money = (40 * days) * 0.9;
        Console.WriteLine(money.ToString("0.00"));
    }
    else if (accommodation == "Camping") {
        money = (10 * days) * 0.9;
        Console.WriteLine(money.ToString("0.00"));
    }
}

