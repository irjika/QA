﻿int centuries = int.Parse(Console.ReadLine());
int years = centuries * 100;
double days = Math.Round(years * 365.2422);
int hours = (int)days * 24;
int minutes = hours * 60;

Console.WriteLine(centuries + " centuries = " + years + " years = " + days + " days = " + hours + " hours = " + minutes + " minutes"); 
