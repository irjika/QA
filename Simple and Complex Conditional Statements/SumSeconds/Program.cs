int sec1 = int.Parse(Console.ReadLine());
int sec2 = int.Parse(Console.ReadLine());
int sec3 = int.Parse(Console.ReadLine());

//Calculate their total time in the format "minutes:seconds"
// The seconds should be displayed with leading zero (2 as "02", 7 as "07", 35 as "35").

int total = sec1 + sec2 + sec3;

int minutes = total / 60;
int seconds = total - (minutes * 60);
if (seconds > 9)
{
    Console.WriteLine(minutes + ":" + seconds);
}
else
{
    Console.WriteLine(minutes + ":" + "0" + seconds);
}