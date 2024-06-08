//Aylana yuzasini topish
Console.WriteLine("Aylana radiusi");
Console.Write("Aylana radiusini kiriting:");
string R = Console.ReadLine();
decimal Radius = Convert.ToDecimal(R);
decimal aylanaYuzasi = (3.14m * (Radius * Radius));
Console.WriteLine("aylananing yuzasi " + aylanaYuzasi + " ga teng");
