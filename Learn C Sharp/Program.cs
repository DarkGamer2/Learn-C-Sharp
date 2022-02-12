using Learn_C_Sharp;

Square smallsquare=new Square();
smallsquare.Side = 1;

Square bigsquare=new Square();
bigsquare.Side = 600;

Console.Beep();
Console.WriteLine($"The size of the small square is {smallsquare.Side}");
Console.WriteLine($"The size of the big square is {bigsquare.Side}");