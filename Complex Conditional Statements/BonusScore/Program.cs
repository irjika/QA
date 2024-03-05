//If points are between 0 and 3 (inclusive), adds 5 to the given points

//If points are between 4 and 6 (inclusive), adds 15 to the given points

//If points are between 7 and 9 (inclusive), adds 20 to the given points

int points = int.Parse(Console.ReadLine());
if ((points >= 0) && (points <= 3)){
    points += 5;
    Console.WriteLine(points);
}
else if ((points >= 4) && (points <= 6)) {
    points += 15; 
    Console.WriteLine(points);
}
else if ((points >= 7) && (points <= 9)) {
    points += 20;
    Console.WriteLine(points);
}

