int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();
//•	The office's working hours are from 10 AM to 6 PM, Monday through Saturday, inclusive

//if (((hour >= 10) && (hour <= 18)) && ((day == "Monday") || (day == "Tuesday") || (day == "Wednesday")

if (((hour < 10) || (hour > 18)) || ((day == "Sunday"))) {
    Console.WriteLine("closed");
}
else
{
    Console.WriteLine("open");
}
