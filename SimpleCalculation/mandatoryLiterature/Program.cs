int bookPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysToFinish = int.Parse(Console.ReadLine());

int readingTime = bookPages / pagesPerHour;
int result = readingTime / daysToFinish;
Console.WriteLine(result);
