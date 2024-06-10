using System;

decimal radius;
Console.Write("Enter the radius : ");
string inputNumber = Console.ReadLine();
radius = Convert.ToDecimal(inputNumber);
decimal CicleSurface = (radius * radius * 3.14m);
Console.WriteLine("Cicle surface is equal to " + CicleSurface + " sm^2");
